using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;
public class WritingTest2 : MonoBehaviour
{   
    void Start()
    {
        // DB 연결하기
        string dbName = "/test2.db";
        string connectionString = "URI=file:" + Application.streamingAssetsPath + dbName;
        IDbConnection dbConnerction = new SqliteConnection(connectionString);
        dbConnerction.Open();

    // DB 쓰기
        // 배열 선언
        int[] num = new int[10] {11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
        string[] job = new string[10] {"바보", "경찰", "사제", "부제", "수사", "대학원생", "연구원", "품바","아이돌", "도둑"};
        int[] age = new int[10] {21, 22, 23, 24, 25, 26, 27, 28, 29, 30};
        string[] gender = new string[10] {"남", "남", "남", "남", "남", "여", "여", "여", "여", "여"};

        // 삽입
        for (int i = 0; i < num.Length; i++)
        {
            using (IDbCommand dbCommand = dbConnerction.CreateCommand())
            {
                string insertQuery = $"INSERT INTO test2 (순서, 직업, 나이, 성별) VALUES ({num[i]}, '{job[i]}', {age[i]}, '{gender[i]}')";
                dbCommand.CommandText = insertQuery;
                dbCommand.ExecuteNonQuery();
                dbCommand.Dispose();
            }
        }
        dbConnerction.Close();
    }
}