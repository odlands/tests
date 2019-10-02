using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
using Mono.Data.Sqlite;

public class HighScoreMngr : MonoBehaviour
{

    private string connectionString;
    // Start is called before the first frame update
    void Start()
    {
        connectionString = "URI=file:" + Application.dataPath + "/HighScores.db";
        GetScores();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GetScores()
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                //string sqlAdd = "INSERT INTO HighScores (Name, Score) VALUES (\"Jim\", 500)";
                string sqlQuery = "SELECT * FROM HighScores";

                //dbCmd.CommandText = sqlAdd;
                dbCmd.CommandText = sqlQuery;

                using (IDataReader reader = dbCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Debug.Log(reader.GetString(1));
                        print("Learn SQL");
                    }
                    dbConnection.Close();
                    reader.Close();
                }
            }
        }
    }
}
