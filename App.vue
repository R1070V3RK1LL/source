<template>
  <div id="app" style="background-color:yellow">
    <img alt="Vue logo" src="./assets/ban-the-witcher-3-1021x580.jpg">
    <form action="http://localhost:8080/" method="get">
  <p style="color:red">{{firstname}}</p>
  <em style="color:blue">First name:</em><br> 
  <input type="text" name="firstname" style="color:green;border-color:black" v-model="firstname"><br>
   <p style="color:red">{{lastname}}</p>
  <em style="color:blue">Last name:</em><br>
  <input type="text" name="lastname" style="color:green;border-color:black" v-model="lastname"> <br><br>
  <button type="button" v-on:click="send" style="color:red">OK</button>
    </form>
      <form action="http://localhost:8080/" method="get">
  <p style="color:red">{{workbench}}</p>
  <em style="color:blue">Workbench:</em><br> 
  <input type="text" name="workbench" style="color:green;border-color:black" v-model="workbench"><br>
   <p style="color:red">{{utilitary}}</p>
  <em style="color:blue">Utilitary:</em><br>
  <input type="text" name="utilitary" style="color:green;border-color:black" v-model="utilitary"> <br><br>
  <button type="button" v-on:click="send" style="color:red">OK</button>
    </form>
  <table>
  <button type="button" v-on:click="receive" style="color:red">Import</button>
  <thead>Workbench,Utilitary</thead>
  <!--<tr v-for="(item, key) in products" :key="key"></tr>
    <td>
        {{item.workbench}}
    </td>
    <td>
        {{item.utilitary}}
    </td>-->
  </table>
    <i><strong><br>"Toss a coin to your witcher o'valley of plenty"</strong></i><br>
    <br>
    <footer>
      <strong><em>Main current quest :</em><br><i>Chase the Wild Hund</i></strong>
      <th style="color:red;font-size=30;position=center">Statistics:</th>
      <tr>
        <em>Niveau du joueur : </em>
        <td>32</td>
      </tr>
      <br>
      <tr><em>Equipement:  </em>
        <td>Taer-holn : 320-378 dmg</td>
        <td>Hatchet : 230-248 dmg</td>
        <td>Redanian chest : 165 armor</td>
        <td>Temarian gauntlets : 65 armor</td>
        <td>Nilfgaard pants : 62 armor</td>
        <td>Novigrad boots : 45 armor</td>
      </tr>
      <br>
      <tr><em>Position :</em>
        <td>Skellige</td>
      </tr>
      <br>
      <tr>
        <em>Gold : </em>
        <td>7800</td>
      </tr>
      <br>
      <tr>
        <em>Upgrades : </em>
        <td>Attack:13-41points in branch</td>
      </tr>
      <br>
      <tr>
        <em>Stuff : </em>
        <td>Too many items</td>
      </tr>
    </footer>
  </div>
</template>

<script>
//import axios from 'axios'

export default {
  name: 'app',
  //components: {
   // HelloWorld
  //},
  data:() =>{
    return {
      firstname:"",
      lastname:"",
      workbench:"",
      utilitary:""
    }
  },
  methods:{
  receive:function(){
 var myHeaders = new Headers()
 myHeaders.append("Content-Type","application/json")
 
 this.products = new Request("https://localhost:44386/api/Products",
         {
            headers: myHeaders,
            method: 'GET',})
    alert(this.products)
    fetch(this.products)
      .then(response => 
       {
        if (response.status === 200) {
           alert('Object created')
        } else {
           alert('Something went wrong on api server!');
       }
       })},
    send: function() {
     var myHeaders = new Headers()
      myHeaders.append("Content-Type","application/json")
      const request = new Request("https://localhost:44386/api/Person",
         {
            headers: myHeaders,
            method: 'POST',
            body: JSON.stringify(
              { 
                Firstname:this.firstname,
                Lastname:this.lastname
              }
            )
          })
    fetch(request)
      .then(response => 
       {
        if (response.status === 201) {
           alert('Object created')
        } else {
           alert('Something went wrong on api server!');
       }
       })
     const request2 = new Request("https://localhost:44386/api/Products",
         {
            headers: myHeaders,
            method: 'POST',
            body: JSON.stringify(
              { 
                workbench:this.workbench,
                utilitary:this.utilitary
              }
            )
          })
    alert(request2)
    fetch(request2)
      .then(response => 
       {
        if (response.status === 201) {
           alert('Object created')
        } else {
           alert('Something went wrong on api server!');
       }
       })
    }
  }
}
</script>

<style>
#app {
  font-family: Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
