function China(skin,language)
{
   Person.call(this,skin,language);
}
China.prototype=new Person();
China.prototype.SayHellow=function()
{
   alert("ฤ๚บร!");
}