namespace WeatherSpider.ReadModels
{
    public record Label(string label);
    public record Data(double value);

    public record DataSet (string seriesname, List<Data>data);
    public record Chart (
        string caption,
        string subCaption,
        string numberPrefix,
        string theme,
        string radarfillcolor
        );

    public record Catergory (List<Label> category);
    public record WeatherDataRm(
        Chart chart,
        List<Catergory> categories,
        List<DataSet> dataset
     );
  
}
