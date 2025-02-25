using NotebookTemplate;
using NotebookTemplate.Components.Notebooks;
using ScottPlot;

GeneratorMarkup.StartNotebook();

var virtualNotebook = new VirtualNotebook();
virtualNotebook.AddTextBlock("Blablalba2");

var plot = new Plot();

plot.Add.Pie([
    new PieSlice(10, Color.FromSDColor(System.Drawing.Color.Red), "car"),
    new PieSlice(40, Color.FromSDColor(System.Drawing.Color.Green), "cat"),
    new PieSlice(50, Color.FromSDColor(System.Drawing.Color.Blue), "dog")
    ]);

virtualNotebook.AddPlot(plot);

GeneratorMarkup.EndNotebook();