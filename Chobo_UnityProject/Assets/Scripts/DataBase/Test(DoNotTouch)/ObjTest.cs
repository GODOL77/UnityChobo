using System.Collections;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;

public class ObjTest : MonoBehaviour
{
    // hp Bar 관련
    public HpBar hpBar;

    // DB 연결 관련
        string dbName;
        string connectionString;
        IDbConnection dbConnerction;

    // DB table colum
    string[] columName;
    int pk = 1;
    int level = 5;
    // 테이블 이름
    string tableName; // 테이블 불러오기
    IDbCommand dbCommand;
    // Start is called before the first frame update
    void Start()
    {
        // 이름 설정하기
        dbName = "/ObjTest.db";
        tableName = "ObjTest";

        // 칼럼 생성
        columName = new string [4] {"obj_number", "obj_name", "obj_lv", "obj_hp"};

        // DB 연결하기
        connectionString = "URI=file:" + Application.streamingAssetsPath + dbName;
        dbConnerction = new SqliteConnection(connectionString);
        dbConnerction.Open();

        dbCommand = dbConnerction.CreateCommand();

        // 테이블 새로 만들기
        string createTableQuery = $@"CREATE TABLE IF NOT EXISTS {tableName}(
        {columName[0]} INTEGER PRIMARY KEY AUTOINCREMENT,
        {columName[1]} VACHAR(10),
        {columName[2]}  INTEGER,
        {columName[3]} INTEGER)";

        dbCommand.CommandText = createTableQuery;
        dbCommand.ExecuteNonQuery();

        // 값 삽입하기
        string insertQuery = $@"INSERT INTO {tableName} ({columName[0]}, {columName[1]}, {columName[2]}, {columName[3]})
        VALUES ({pk}, 'LSH', {level}, {hpBar.currHp})";
        int pkCheck = ObjReda();
        if(pkCheck != pk)
        {
        dbCommand.CommandText = insertQuery;
        dbCommand.ExecuteNonQuery();
        dbCommand.Dispose();
        }

    }

    // Update is called once per frame
    void Update()
    {
        // 쿼리 업데이트
        string updateQuery = @$"UPDATE {tableName} 
        SET {columName[3]} = {hpBar.currHp} 
        WHERE {columName[0]} = {pk}";

        dbCommand.CommandText = updateQuery;
        dbCommand.ExecuteNonQuery();
        dbConnerction.Close();
    }

    int ObjReda()
    {
       // DB 읽기
        IDbCommand readCommand = dbConnerction.CreateCommand();
        readCommand.CommandText = $"SELECT {columName[0]} FROM {tableName} WHERE {columName[0]} = {pk}";
        IDataReader dataReader = readCommand.ExecuteReader();
        int pkDB = 0;

        while(dataReader.Read())
        {
            pkDB = dataReader.GetInt32(0);
        }
        dataReader.Close();
        return pkDB;
    }
}