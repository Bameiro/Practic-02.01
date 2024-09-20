using System.Data;

namespace Lib
{
    namespace UnitTestProject1
    {

        public class ProfileTests
        {
            [Fact]
            public void Value()
            {
                var expectedName = "ФИО";
                var expectedType = "Роль";

                var profile = ProfileDataManager.LoadProfile();

                Assert.NotNull(profile);
                Assert.Equal(expectedName, profile.Fio);
                Assert.Equal(expectedType, profile.Role);
            }
        }

        public class CommentTest //Проверка на заполнение полей строковыми значениями
        {
            [Fact]
            public void CommentBox()
            {
                var expectedInmessage = "Будем разбираться!";
                var inmessage = CommentManager.Inmessage;
                var expectedMasterId = "3";
                var masterID = CommentManager.MasterID;
                var expectedRequesId = "3";
                var requestID = CommentManager.RequestID;


                inmessage = expectedInmessage;
                masterID = expectedMasterId;
                requestID = expectedRequesId;

                Assert.Equal(expectedInmessage, inmessage);
                Assert.Equal(expectedMasterId, masterID);
                Assert.Equal(expectedRequesId, requestID);

            }

        }

        public class HistoryTests //Проверяется заполнение полей в форме из базы данных
        {
            private class MockConnection : IDisposable
            {
                public void Open() { }
                public void Close() { }
                public void Dispose() { }
            }

            private class MockDataAdapter : IDisposable
            {
                public DataTable DataTable { get; } = new DataTable("History");
                public MockDataAdapter(IEnumerable<DataRow> dataRows)
                {
                    foreach (var column in new[] {"Date", "login", "password", "autorisation" })
                    {
                        DataTable.Columns.Add(column, typeof(string));
                    }

                    foreach (var row in dataRows)
                    {
                        DataTable.Rows.Add(row.ItemArray);
                    }
                }

                public void Fill(DataSet dataSet, string tableName)
                {
                    dataSet.Tables.Add(DataTable);
                }

                public void Dispose() { }
            }

            [Fact]
            public void Colums()
            {
                var expectedColumns = new[] { "Date", "login", "password", "autorisation" };

                var historyLogManager = new HistoryLogManager(@"Data Source=CLG;Initial Catalog=AutoServMGY;Integrated Security=True");
                var actualTable = historyLogManager.GetAllLoginHistory();

                Assert.NotNull(actualTable);
                Assert.Equal(expectedColumns, actualTable.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToArray());
            }

        }


        public class LoginTests //Проверка функции проверки на наличие аккаунта
        {
            public string[] currentLogin = { "login1", "login2", "login11" };
            public string[] currentPass = { "pass1", "pass2", "pass11" };

            [Fact]
            public void login()
            {
                User user = new User();
                string log = user.Login = "login11";
                string pass = AuthenticationManager.Pass = "pass11";
                bool userFound = AuthenticationManager.UserFound;
                for (int i = 0; i < currentLogin.Length; i++)
                {
                    if (log == currentLogin[i] && pass == currentPass[i])
                    {
                        userFound = true;
                        break;
                    }
                    else { userFound = false; }

                }

                Assert.True(userFound);
            }

        }

        public class RequestTest//Проверка на возможность создания новой записи в таблице заявки
        {
            [Fact]
            public void CreateRequest_ShouldSetProperties()
            {
                var requestText = "Test request";
                var masterID = 123;
                var requestManager = new RequestManager();

                requestManager.CreateRequest(requestText, masterID);

                Assert.Equal(requestText, requestManager.RequestText);
                Assert.Equal(masterID, requestManager.SaffID);
            }
        }
    }
}
