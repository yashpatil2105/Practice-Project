const express = require("express")
const app = express()
const bodyparser = require('body-parser')
const mysql = require('mysql')
const cors = require('cors')

app.use(express.json())
app.use(bodyparser.urlencoded({extended:true}))
app.use(cors())

const db = mysql.createConnection({
    host:'localhost',
    user:'root',
    password:'yash',
    database:'test'
})

db.connect()


app.get('/',(req,resp)=>{
    db.query("SELECT * FROM vehicle",(err,result)=>{
        if(err){
        console.log(err);
        }else{
            resp.send(result);
        }
    })
    
});

app.get('/display',(req,resp)=>{
    db.query("SELECT * FROM vehicle",(err,result)=>{
        if(err){
        console.log(err);
        }else{
            resp.send(result);
            console.log(result);
        }
    })
    
});

app.post('/insert',(req,resp)=>{
    const vid = req.body.vid;
    const vname = req.body.vname;
    const price = req.body.price;
    const descript = req.body.descript;
    console.log(vid+"========"+vname+"========"+price);

    db.query("INSERT INTO vehicle VALUES(?,?,?,?)",[vid,vname,price,descript],(err,result)=>{
        if(err){
        console.log(err);
        }else{
            resp.send(result);
        }
    }) 
});

app.listen(4000,()=>{
    console.log("server running on 4000")
})
