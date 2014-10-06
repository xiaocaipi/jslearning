function American(skin,language)
{
   Person.call(this,skin,language);
}
American.prototype=new Person();
American.prototype.SayHellow=function()
{
   alert("Hellow!");
}