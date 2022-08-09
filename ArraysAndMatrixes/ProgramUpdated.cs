namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arrays myMatrix = new Arrays();
            int[,] mat = myMatrix.GetDim2Array();           
            myMatrix.PrintDim2Array(mat);
            
            //int determinant = myMatrix.GetDeterminant(mat);
            //Console.WriteLine("The determinant of the {0}x{1} matrix generated is: {2}", mat.GetLength(0), mat.GetLength(1), determinant);

            //Console.WriteLine("\nYou are multiplying the matrix you created by another: ");
            int[,] mat2 = myMatrix.GetDim2Array();
            int[,] multResult = myMatrix.MultDim2Array(mat, mat2);
            myMatrix.PrintDim2Array(multResult);
            //Arrays Dime3Array = new Arrays(); // create an array object named Dime3Array
            //int[,,] dim3Array = Dime3Array.GetDim3Array(); // Create a 3d array using getDim3Array() method in the Arrays class
            //Dime3Array.PrintDim3Array(dim3Array); // Call the PrintDim3Array() method from the Arrays class
            //int[,,] multResult = Dime3Array.MultDim3Array(dim3Array);
            //Dime3Array.PrintDim3Array(multResult);

        }
            
    }
}