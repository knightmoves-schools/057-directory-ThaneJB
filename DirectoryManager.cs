namespace knightmoves;

public class DirectoryManager{

    public void Create(string directoryName){
        // Add your code here
        string test-directory = Path.GetTempPath() + "assignment";
        Directory.CreateDirectory(test-directory);
    }
}