namespace knightmoves;

public class DirectoryManager{

    public void Create(string directoryName){
        // Add your code here
        string newDirectory = Path.Combine(directoryName, "test-directory");
        Directory.CreateDirectory(newDirectory);
    }
}