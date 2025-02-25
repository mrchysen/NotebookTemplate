using NotebookTemplate.Components.Notebooks;
using System.Windows;

namespace NotebookTemplate;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        AddNotebooksFromFolder();
    }

    private void AddNotebooksFromFolder()
    {
        var assembly = GetType().Assembly;

        var notebooks = assembly.DefinedTypes
            .Where(s => s.Name.Contains("Notebook") && char.IsDigit(s.Name.Last()))
            .Select(Activator.CreateInstance)
            .Where(s => s is GeneratedNotebook)
            .Select(s => ((GeneratedNotebook)s!).CreateNotebook())
            .ToList();

        Notebooks.AddNotebooks(notebooks);
    }
}