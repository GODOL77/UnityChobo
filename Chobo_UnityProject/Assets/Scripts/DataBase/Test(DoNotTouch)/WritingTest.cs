using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;
public class WritingTest : MonoBehaviour
{   
    void Start()
    {
        // DB 연결하기
        string dbName = "/Test.db";
        string connectionString = "URI=file:" + Application.streamingAssetsPath + dbName;
        IDbConnection dbConnerction = new SqliteConnection(connectionString);
        dbConnerction.Open();

        // DB 쓰기
        int num = 11;
        string job = "바보";
        int age = 50;
        string gender = "남자";
        string insertQuery = $"INSERT INTO Test (순서, 직업, 나이, 성별) VALUES ({num}, '{job}', {age}, '{gender}')";

        IDbCommand dbCommand = dbConnerction.CreateCommand();
        dbCommand.CommandText = insertQuery;
        dbCommand.ExecuteNonQuery();
        dbCommand.Dispose();
        dbConnerction.Close();
    }
}