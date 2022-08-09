namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arrays myMatrix = new Arrays();
            int[,] mat = myMatrix.GetDim2Array();
            myMatrix.PrintDim2Array(mat);
            
            int determinant = myMatrix.GetDeterminant(mat);
            Console.WriteLine("\nThe determinant of the {0}x{1} matrix you created is: {2}", mat.GetLength(0), mat.GetLength(1), determinant);
            
            Arrays Dime3Array = new Arrays();
            int[,,] dim3Array = Dime3Array.GetDim3Array();
            Dime3Array.PrintDim3Array(dim3Array);
        }
            
    }
}