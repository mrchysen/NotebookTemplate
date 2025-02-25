namespace NotebookTemplate.Components.Notebooks;

public interface INotebookHandler
{
    void AddNotebooks(IEnumerable<VirtualNotebook> notebooks);
}