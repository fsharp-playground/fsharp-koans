module Wk


let testPrint x = printfn "value = %s\n" x

let testMySql() = 
    let connectionStr = "Data Source=10.0.0.77; Port=3306; User ID=root; Password=1234; Database=db_aiadoc;" 
    new MySql.Data.MySqlClient.MySqlConnection(connectionStr)

let x = testMySql()
