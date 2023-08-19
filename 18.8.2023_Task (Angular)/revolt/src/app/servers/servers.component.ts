import { Component } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})
export class ServersComponent {
s1="SQL"
s2="Oracle"
serverCreated:string="";
servername:string =""
serverlist =['SQL','Oracle'];

addNewServer:boolean = false;
constructor()
{
  setTimeout (( )=>
    {
this.addNewServer = true;
    },5000
  );
}

serverremove(){
  this.serverCreated = "Deleted";
}
onserverCreation()
{
  this.serverCreated = "created";
  
}

serverId:number =1001;
serverStatus:string = 'offline';

getServerId()
{
  return this.serverId;
}
getServerStatus()
{
  return this.serverStatus;
}

onserverNameEntry(event:Event)
{
  console.log(event);
  this.servername = (<HTMLInputElement>event.target).value;
}
}
