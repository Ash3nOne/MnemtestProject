using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MnemotestProject.Model
{
    static public class MnemotestDB
    {
        static private readonly string connectionString = ConfigurationManager.ConnectionStrings["MnemotestDB"].ConnectionString;

        static private SqlConnection sqlConnection = null;

        static private SqlDataReader sqlDataReader = null;

        static private SqlCommand sqlCommand = null;


        static private bool OpenConnection()
        {
            sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        static private void CloseConnection()
        {
            sqlConnection.Close();
        }

        static public long AddPerson(Person person)
        {
            if (OpenConnection())
            {
                long result = -1;
                try
                {
                    if (person.FatherName == string.Empty)
                        sqlCommand = new SqlCommand($"AddPerson N'{person.LastName}', N'{person.FirstName}', {person.Age}, {person.Gender}, '{person.InsurancePolicy}'", sqlConnection);
                    else
                        sqlCommand = new SqlCommand($"AddPerson N'{person.LastName}', N'{person.FirstName}', {person.Age}, {person.Gender}, '{person.InsurancePolicy}', N'{person.FatherName}'", sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    result = sqlDataReader.GetInt64(0);
                    sqlDataReader.Close();

                }
                catch
                {
                    throw new Exception("Произошла ошибка при добавлении.");
                }
                finally
                {
                    CloseConnection();
                }
                return result;
            }
            else
                throw new Exception("База данных не найдена.");
        }

        static public void AddResult(long personId, double averageCorrectAnswersCount, double correctAnswersDispersion, double averageInvalidAnswersCount, 
            double invalidAnswersDispersion, double averageTime, double timeDispersion, MnemotestParameters parameters)
        {
            if (OpenConnection())
            {
                try
                {
                    string command = $"AddResult {personId}, {averageCorrectAnswersCount.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}, {correctAnswersDispersion.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}, " +
                    $"{averageInvalidAnswersCount.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}, {invalidAnswersDispersion.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}, " +
                    $"{averageTime.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}, {timeDispersion.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}, {parameters.ExposureTime}, {parameters.PreExposureTime}, " +
                    $"{parameters.PostExposureTime}, {parameters.Difficult}, {(parameters.ReproductionMode ? 1 : 0)}, {parameters.RotateCount}, {parameters.Size}, {parameters.Attempts}, {parameters.Scatter}";
                    sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    sqlDataReader.Close();
                }
                catch
                {
                    throw new Exception("Произошла ошибка при добавлении результата.");
                }
                finally
                {
                    CloseConnection();
                }
            }
            else
                throw new Exception("База данных не найдена.");
        }



        static public List<List<string>> GetDefaultParameters()
        {
            if (OpenConnection())
            {
                List<List<string>> data = new List<List<string>>();
                try
                {
                    string command = "GetDefaultParameters";
                    sqlCommand = new SqlCommand(command, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        List<string> row = new List<string>
                        {
                            sqlDataReader["ParametersName"].ToString(),
                            sqlDataReader["ExposureTime"].ToString(),
                            sqlDataReader["PreExposureTime"].ToString(),
                            sqlDataReader["PostExposureTime"].ToString(),
                            sqlDataReader["Difficult"].ToString(),
                            sqlDataReader["ReproductionMode"].ToString(),
                            sqlDataReader["RotationAngle"].ToString(),
                            sqlDataReader["MatrixSize"].ToString(),
                            sqlDataReader["Attempts"].ToString(),
                            sqlDataReader["ScatterNumber"].ToString()
                        };
                        data.Add(row);
                    }
                    sqlDataReader.Close();
                }
                catch
                {
                    throw new Exception("При поиске шаблонов произошла ошибка.");
                }
                finally
                {
                    CloseConnection();
                }
                if (data.Count == 0)
                    throw new Exception("В базе данных нет параметров по умолчанию.");
                return data;
            }
            else
                throw new Exception("База данных не найдена.");
        }

        static public bool IsValidPerson(Person person)
        {
            if (OpenConnection())
            {
                try
                {
                    string command = "IsValidPerson";
                    sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = command;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@LastName", person.LastName);
                    sqlCommand.Parameters.AddWithValue("@FirstName", person.FirstName);
                    sqlCommand.Parameters.AddWithValue("@Age", person.Age);
                    sqlCommand.Parameters.AddWithValue("@Gender", person.Gender);
                    sqlCommand.Parameters.AddWithValue("@InsurancePolicy", person.InsurancePolicy);

                    sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    int result = sqlDataReader.GetInt32(0);
                    sqlDataReader.Close();
                    if (result == 0)
                        return false;
                    else
                        return true;
                }
                catch
                {
                    throw new Exception("При проверке произошла ошибка.");
                }
                finally 
                {
                    CloseConnection();
                }
            }
            else
                throw new Exception("База данных не найдена.");
        }

        static public List<UserResult> GetAllResults(string insurancePolicy)
        {
            if (OpenConnection())
            {
                List<UserResult> data = new List<UserResult>();
                try
                {
                    string command = "GetAllTestResultsForPolicy";
                    sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = command;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@InsurancePolicy", insurancePolicy);

                    sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        string lastName = (sqlDataReader["LastName"].ToString());
                        string firstName = (sqlDataReader["FirstName"].ToString());
                        string fatherName = (sqlDataReader["FatherName"].ToString());
                        int age = (Convert.ToInt32(sqlDataReader["Age"]));
                        int gender = (Convert.ToInt32(sqlDataReader["Gender"]));
                        double averageCorrectAnswersCount = (Convert.ToDouble(sqlDataReader["AverageCorrectAnswersCount"]));
                        double correctAnswersDispersion = (Convert.ToDouble(sqlDataReader["CorrectAnswersDispersion"]));
                        double averageinvalidAnswersCount = (Convert.ToDouble(sqlDataReader["AverageInvalidAnswersCount"]));
                        double invalidAnswersDispersion = (Convert.ToDouble(sqlDataReader["InvalidAnswersDispersion"]));
                        double averageTime = (Convert.ToDouble(sqlDataReader["AverageTime"]));
                        double timeDispersion = (Convert.ToDouble(sqlDataReader["TimeDispersion"]));
                        int exposureTime = (Convert.ToInt32(sqlDataReader["ExposureTime"]));
                        int postExposureTime = (Convert.ToInt32(sqlDataReader["PostExposureTime"]));
                        int preExposureTime = (Convert.ToInt32(sqlDataReader["PreExposureTime"]));
                        int difficult = (Convert.ToInt32(sqlDataReader["Difficult"]));
                        bool reproductionMode = (sqlDataReader["ReproductionMode"].ToString() == "1");
                        int rotationAngle = (Convert.ToInt32(sqlDataReader["RotationAngle"]));
                        int matrixSize = (Convert.ToInt32(sqlDataReader["MatrixSize"]));
                        int attempts = (Convert.ToInt32(sqlDataReader["Attempts"]));
                        int scatter = (Convert.ToInt32(sqlDataReader["ScatterNumber"]));
                        MnemotestParameters parameters = new MnemotestParameters(exposureTime, postExposureTime, preExposureTime, difficult, reproductionMode, rotationAngle, matrixSize, attempts, scatter);
                        Person person = new Person(firstName, lastName, fatherName, insurancePolicy, age, gender);
                        UserResult user = new UserResult(parameters, person, averageCorrectAnswersCount, correctAnswersDispersion, averageinvalidAnswersCount, invalidAnswersDispersion, averageTime, timeDispersion);
                        data.Add(user);
                    }
                    sqlDataReader.Close();
                    
                }
                catch
                {
                    throw new Exception("При поиске результатов произошла ошибка.");
                }
                finally
                {
                    CloseConnection();
                }
                if (data.Count == 0)
                    throw new Exception("По данному полису результаты не найдены.");
                return data;
            }
            else
                throw new Exception("База данных не найдена.");
        }

        public static void AddTemplateToDB(string name, MnemotestParameters parameters)
        {
            if (OpenConnection())
            {
                try
                {
                    string command = "AddDefaultParameters";
                    sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = command;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@ParametersName", name);
                    sqlCommand.Parameters.AddWithValue("@ExposureTime", parameters.ExposureTime);
                    sqlCommand.Parameters.AddWithValue("@PreExposureTime", parameters.PreExposureTime);
                    sqlCommand.Parameters.AddWithValue("@PostExposureTime", parameters.PostExposureTime);
                    sqlCommand.Parameters.AddWithValue("@Difficult", parameters.Difficult);
                    sqlCommand.Parameters.AddWithValue("@ReproductionMode", parameters.ReproductionMode);
                    sqlCommand.Parameters.AddWithValue("@RotationAngle", parameters.RotateCount);
                    sqlCommand.Parameters.AddWithValue("@MatrixSize", parameters.Size);
                    sqlCommand.Parameters.AddWithValue("@Attempts", parameters.Attempts);
                    sqlCommand.Parameters.AddWithValue("@ScatterNumber", parameters.Scatter);
                    sqlDataReader = sqlCommand.ExecuteReader();
                    sqlDataReader.Read();
                    sqlDataReader.Close();
                }
                catch (Exception ex)
                {
                    if (ex is SqlException && ((SqlException)ex).Number == 2627)
                        throw new Exception("Такое имя уже используется.");
                    throw new Exception("При добавлении шаблона произошла ошибка.");
                }
                finally
                {
                    CloseConnection();
                }
            }
            else
                throw new Exception("База данных не найдена.");
        }

    }
}
