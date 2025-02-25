namespace NotebookTemplate.Components.Notebooks;

public interface INotebookFromFolderCreater
{
    IEnumerable<VirtualNotebook> ReadAllNotebooks(string notebookNamespace);
}

public class NotebookFromFolderCreater // ToDo do it
{

}
