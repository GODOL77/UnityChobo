using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;
public class CreatingTest : MonoBehaviour
{
void Start()
    {
        // DB 연결하기
        string dbName = "/Test.db";
        string connectionString = "URI=file:" + Application.streamingAssetsPath + dbName;
        IDbConnection dbConnerction = new SqliteConnection(connectionString);
        dbConnerction.Open();

        // 테이블 새로 만들기
        string createTableQuery = @"CREATE TABLE IF NOT EXISTS newtable(
        No INTEGER PRIMARY KEY AUTOINCREMENT,
        Name TEXT NOT NULL,
        Job TEXT NOT NULL,
        Address TEXT NOT NULL)";

        IDbCommand dbCommand = dbConnerction.CreateCommand();
        dbCommand.CommandText = createTableQuery;
        dbCommand.ExecuteNonQuery();

        dbConnerction.Close();
    }
}
