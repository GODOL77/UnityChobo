using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;
public class ReadingTest : MonoBehaviour
{   
    void Start()
    {
        // DB 연결하기
        string dbName = "/Test.db";
        string connectionString = "URI=file:" + Application.streamingAssetsPath + dbName;
        IDbConnection dbConnerction = new SqliteConnection(connectionString);
        dbConnerction.Open();

        // DB 읽기
        string tableName = "Test"; // 테이블 불러오기
        IDbCommand dbCommand = dbConnerction.CreateCommand();
        dbCommand.CommandText = "SELECT * FROM " + tableName;
        IDataReader dataReader = dbCommand.ExecuteReader();
        
        while(dataReader.Read())
        {
            string name = dataReader.GetString(1);
            int age = dataReader.GetInt32(2);
            Debug.Log("Name : " + name + ", Age : " + age);
        }
        dataReader.Close();
    }
}