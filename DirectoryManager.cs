namespace knightmoves;

public class DirectoryManager{

    public void Create(string directoryName){
        // Add your code here
        string testDirectory = Path.GetTempPath() + "assignment";
        Directory.CreateDirectory(testDirectory);
    }
}