using system;

namespace myprogram
{
  class program
  { 
    static void main(string[] args)
    {
      //Declare an array to store list of grains
    
      string[] grains = {"oats","wheat","rice"};
      
       // accessing the array

       console.writeline(grain[0]);
       console.writeline(grain[1]);
       console.writeline(grain[2]);

       // Assignment02 declaring and initializing a two dimentional array

       // declaring the array with dimention

       string[] cars =new string{2};
       
       // assigning values to the array

       cars[0] = "toyota";
       cars[1] = "tesla";

       // you can also access the array

       console.writeline(car[0]);

       // Assignment03 tranversing array
       // tranversing an array of grains above

       for (int i =0; i < grain.length; i++)
       {
          console.writeline(grain[i]);
       } 
     
       // Assignment04 concatinating and array
       // concactinating the arrays of grains and cars above
       
        string[] join_array = grains.Union(cars).toarray();
        console.writeline("\n join array");
        printArray(numbers);       

        console.Readkey();
    }

       // creating a method that will help print concatinated array
      
       private static void printArray(string[] join_array)
       {
          foreach (var item in join_array)
          {
            console.write(item);
          }
       }
  }

}
      

