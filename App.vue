<template>

  <div id="app" style="background-color:black">
    <div class="hero">
    <div class="snow">
        <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 1024 1536" preserveAspectRatio="xMidYMax slice">
            <g fill="#FFF" fill-opacity=".15" transform="translate(55 42)">
               <g id="snow-bottom-layer">
                  <ellipse cx="6" cy="1009.5" rx="6" ry="5.5"/>
                  <ellipse cx="138" cy="1110.5" rx="6" ry="5.5"/>
                  <ellipse cx="398" cy="1055.5" rx="6" ry="5.5"/>
                  <ellipse cx="719" cy="1284.5" rx="6" ry="5.5"/>
                  <ellipse cx="760" cy="1155.5" rx="6" ry="5.5"/>
                  <ellipse cx="635" cy="1459.5" rx="6" ry="5.5"/>
                  <ellipse cx="478" cy="1335.5" rx="6" ry="5.5"/>
                  <ellipse cx="322" cy="1414.5" rx="6" ry="5.5"/>
                  <ellipse cx="247" cy="1234.5" rx="6" ry="5.5"/>
                  <ellipse cx="154" cy="1425.5" rx="6" ry="5.5"/>
                  <ellipse cx="731" cy="773.5" rx="6" ry="5.5"/>
                  <ellipse cx="599" cy="874.5" rx="6" ry="5.5"/>
                  <ellipse cx="339" cy="819.5" rx="6" ry="5.5"/>
                  <ellipse cx="239" cy="1004.5" rx="6" ry="5.5"/>
                  <ellipse cx="113" cy="863.5" rx="6" ry="5.5"/>
                  <ellipse cx="102" cy="1223.5" rx="6" ry="5.5"/>
                  <ellipse cx="395" cy="1155.5" rx="6" ry="5.5"/>
                  <ellipse cx="826" cy="943.5" rx="6" ry="5.5"/>
                  <ellipse cx="626" cy="1054.5" rx="6" ry="5.5"/>
                  <ellipse cx="887" cy="1366.5" rx="6" ry="5.5"/>
                  <ellipse cx="6" cy="241.5" rx="6" ry="5.5"/>
                  <ellipse cx="138" cy="342.5" rx="6" ry="5.5"/>
                  <ellipse cx="398" cy="287.5" rx="6" ry="5.5"/>
                  <ellipse cx="719" cy="516.5" rx="6" ry="5.5"/>
                  <ellipse cx="760" cy="387.5" rx="6" ry="5.5"/>
                  <ellipse cx="635" cy="691.5" rx="6" ry="5.5"/>
                  <ellipse cx="478" cy="567.5" rx="6" ry="5.5"/>
                  <ellipse cx="322" cy="646.5" rx="6" ry="5.5"/>
                  <ellipse cx="247" cy="466.5" rx="6" ry="5.5"/>
                  <ellipse cx="154" cy="657.5" rx="6" ry="5.5"/>
                  <ellipse cx="731" cy="5.5" rx="6" ry="5.5"/>
                  <ellipse cx="599" cy="106.5" rx="6" ry="5.5"/>
                  <ellipse cx="339" cy="51.5" rx="6" ry="5.5"/>
                  <ellipse cx="239" cy="236.5" rx="6" ry="5.5"/>
                  <ellipse cx="113" cy="95.5" rx="6" ry="5.5"/>
                  <ellipse cx="102" cy="455.5" rx="6" ry="5.5"/>
                  <ellipse cx="395" cy="387.5" rx="6" ry="5.5"/>
                  <ellipse cx="826" cy="175.5" rx="6" ry="5.5"/>
                  <ellipse cx="626" cy="286.5" rx="6" ry="5.5"/>
                  <ellipse cx="887" cy="598.5" rx="6" ry="5.5"/>
               </g>
            </g>
            <g fill="#FFF" fill-opacity=".3" transform="translate(65 63)">
               <g id="snow-top-layer">
                  <circle cx="8" cy="776" r="8"/>
                  <circle cx="189" cy="925" r="8"/>
                  <circle cx="548" cy="844" r="8"/>
                  <circle cx="685" cy="1115" r="8"/>
                  <circle cx="858" cy="909" r="8"/>
                  <circle cx="874" cy="1438" r="8" transform="rotate(180 874 1438)"/>
                  <circle cx="657" cy="1256" r="8" transform="rotate(180 657 1256)"/>
                  <circle cx="443" cy="1372" r="8" transform="rotate(180 443 1372)"/>
                  <circle cx="339" cy="1107" r="8" transform="rotate(180 339 1107)"/>
                  <circle cx="24" cy="1305" r="8" transform="rotate(180 24 1305)"/>
                  <circle cx="8" cy="8" r="8"/>
                  <circle cx="189" cy="157" r="8"/>
                  <circle cx="548" cy="76" r="8"/>
                  <circle cx="685" cy="347" r="8"/>
                  <circle cx="858" cy="141" r="8"/>
                  <circle cx="874" cy="670" r="8" transform="rotate(180 874 670)"/>
                  <circle cx="657" cy="488" r="8" transform="rotate(180 657 488)"/>
                  <circle cx="443" cy="604" r="8" transform="rotate(180 443 604)"/>
                  <circle cx="339" cy="339" r="8" transform="rotate(180 339 339)"/>
                  <circle cx="24" cy="537" r="8" transform="rotate(180 24 537)"/>
               </g>
            </g>
        </svg>
    </div>
    
    <div class="hero__content">
        <h1 style="color:red">Witcher 3</h1>
    </div>

</div>

    <img alt="Vue logo" src="./assets/ban-the-witcher-3-1021x580.jpg" width=42% height=42%>

    <form action="http://localhost:8080/" method="get">

  <p style="color:red">{{firstname}}</p>

  <em style="color:yellow">First name:</em><br> 

  <input type="text" name="firstname" style="color:green;border-color:black" v-model="firstname"><br>

   <p style="color:red">{{lastname}}</p>

  <em style="color:yellow">Last name:</em><br>

  <input type="text" name="lastname" style="color:green;border-color:black" v-model="lastname"> <br>

  <button type="button" v-on:click="send" style="color:red">OK</button>

    </form>

      <form action="http://localhost:8080/" method="get">

  <p style="color:red">{{workbench}}</p>

  <em style="color:yellow">Workbench:</em><br> 

  <input type="text" name="workbench" style="color:green;border-color:black" v-model="workbench"><br>

   <p style="color:red">{{utilitary}}</p>

  <em style="color:yellow">Utilitary:</em><br>

  <input type="text" name="utilitary" style="color:green;border-color:black" v-model="utilitary"> <br>

  <button type="button" v-on:click="send" style="color:red">OK</button><br><br>

    </form>
  <form action="http://localhost:8080/" method="get">
 <select name="Difficulté" style="color:black;border-color:blue">
 <option value="Story only">Story only</option>
 <option value="Story and swords">Story and swords</option>
 <option value="Swords and monsters">Swords and monsters</option>
 <option value="Blood and death">Blood and death</option>
 </select>
 <button type="button" v-on:click="send" style="color:black">OK</button>
 </form><br>
 <div class="view_port">
  <div class="polling_message">
    En attente
  </div>
  <div class="cylon_eye"></div>
</div>
  <table method="get">
  <button type="button" v-on:click="receive" style="color:red">Import</button>
  <thead style="color:yellow">Workbench,Utilitary</thead>
  <!--<tr v-for="product in products" :key="product.Id"></tr>
    <td>
        {{product.Workbench}}
    </td>
    <td>
        {{product.Utilitary}}
    </td>-->
</table>

    <i style="color:yellow"><strong><br>"Toss a coin to your witcher o'valley of plenty"</strong></i><br>

    <br>

    <footer>

      <strong style="color:yellow"><em>Main current quest :</em><br><i>Investigate Cintran's manor</i></strong><br>
      <table id="t2">
      <th style="color:red;font-size=30">Statistics:</th>

      <tr>

        <em style="color:yellow">Niveau du joueur : </em>

        <td style="color:yellow">46</td>

      </tr>

      <br>

      <tr><em style="color:yellow">Equipement:  </em>

        <td style="color:yellow"> Taer-holn : 440-478 dmg</td>

        <td style="color:yellow"> Iris : 330-388 dmg</td>

        <td style="color:yellow"> Toussaint armor : 250 armor</td>

        <td style="color:yellow"> Toussaint gauntlets : 84 armor</td>

        <td style="color:yellow"> Toussaint pants : 85 armor</td>

        <td style="color:yellow"> Toussaint boots : 65 armor</td>

      </tr>

      <br>

      <tr><em style="color:yellow">Position :</em>

        <td style="color:yellow">Duchy of Toussaint</td>

      </tr>

      <br>

      <tr>

        <em style="color:yellow">Gold : </em>

        <td style="color:yellow">5800</td>

      </tr>

      <br>

      <tr>

        <em style="color:yellow">Upgrades : </em>

        <td style="color:yellow">Attack:14-54 points in branch</td>
        <td style="color:yellow">Sign:2-6 points in branch</td>

      </tr>
    </table>
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

      utilitary:"",
      products:[],
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

     const requestlist = new Request("https://localhost:44386/api/Products",

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

    alert(requestlist)

    fetch(requestlist)

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
  font: size 132px;

}
table#t2{
  width:100%;
  text-align:center;
}
.polling_message {
  color: rgb(60, 255, 0);
  float: middle;  
}

.view_port {
  background-color: black;
  height: 25px;
  width: 100%;
  overflow: hidden;
}

.cylon_eye {
  background-color: red;
  background-image:         linear-gradient(to right, rgba( 0,0,0,0.9 ) 25%, rgba( 0,0,0,0.1 ) 50%, rgba( 0,0,0,0.9 ) 75%);
  color: white;
  height: 100%;
  width: 20%;
          animation: 4s linear 0s infinite alternate move_eye;
}
        @keyframes move_eye { from { margin-left:-20%; } to { margin-left:100%; }  }
img:hover{
animation:iliketomoveit 2s infinite;
}
@keyframes iliketomoveit{
   from {
        transform: translateX(0px);
    }

    30% {
        transform: translateX(150px);
    }

    60% {
        transform: translateX(150px) rotate(30deg);
    }

    80% {
        transform: translate(100px, 80px) rotate(30deg);
    }

    to {
        transform: translate(100px, 80px) rotate(30deg);
        border-radius: 30px;
        background-color: red;
    }
}
@import url("https://fonts.googleapis.com/css?family=Corben:700");
h1 {
  font-family: 'Corben', cursive;
  font-size: 6rem;
  color: white;
  letter-spacing: 0.1rem;
  text-shadow: 0px 3px 3px rgba(0, 0, 0, 0.66);
}

.hero {
  background-image: radial-gradient(50% 176% #253854 80% #061922 100%);
  min-height: 30rem;
  position: relative;
  overflow: hidden;
  display: -webkit-box;
  display: flex;
  -webkit-box-pack: center;
          justify-content: center;
  align-content: center;
}
.hero__content {
  position: relative;
  align-self: center;
  padding: 3rem 0;
}

.snow {
  position: absolute;
  min-width: 100vw;
  min-height: 100vh;
  height: 100%;
  width: 100%;
  top: 0;
  left: 0;
}

.snow .svg {
  position: absolute;
  width: 100%;
  height: 100%;
}

#snow-top-layer {
  will-change: transform;
  -webkit-transform: translateY(-768px);
          transform: translateY(-768px);
  -webkit-animation: fall 22.5s infinite linear;
          animation: fall 22.5s infinite linear;
}

#snow-bottom-layer {
  will-change: transform;
  -webkit-transform: translateY(-768px);
          transform: translateY(-768px);
  -webkit-animation: fall 45s infinite linear;
          animation: fall 45s infinite linear;
}

@-webkit-keyframes fall {
  100% {
    -webkit-transform: translateY(0);
            transform: translateY(0);
  }
}

@keyframes fall {
  100% {
    -webkit-transform: translateY(0);
            transform: translateY(0);
  }
}
</style>


