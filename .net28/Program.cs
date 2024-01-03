// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int num2=8,num1=2,resultado=0;


try
{

resultado=num2/num1;

}catch(Exception e){

Console.WriteLine("no se puede dividir entre 0");
resultado=0;

}

finally 
{
    Console.WriteLine("el resultado es {0}/{1}={2}",num2,num1,resultado);
}