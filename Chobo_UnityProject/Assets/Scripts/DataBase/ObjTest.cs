using System.Collections;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;

public class ObjTest : MonoBehaviour
{
    // hp Bar 관련
    public HpBar hpBar;
    int nowHp;

    // DB 연결 관련
        string dbName;
        string connectionString;
        IDbConnection dbConnerction;

    // DB table colum
    string[] columName;
    // 테이블 연결
    string tableName; // 테이블 불러오기
    IDbCommand dbCommand;
    // Start is called before the first frame update
    void Start()
    {
        nowHp = hpBar.currHp;

        // DB 연결하기
        dbName = "/Test.db";
        connectionString = "URI=file:" + Application.streamingAssetsPath + dbName;
        dbConnerction = new SqliteConnection(connectionString);
        dbConnerction.Open();

        // 테이블 연결
        tableName = "Test"; // 테이블 불러오기
        dbCommand = dbConnerction.CreateCommand();
        
        // DB 컬럼 설정하기
        columName = new string[4] {"ch_name", "ch_level", "ch_hp", "ch_exp"};
    }

    // Update is called once per frame
    void Update()
    {}
}
