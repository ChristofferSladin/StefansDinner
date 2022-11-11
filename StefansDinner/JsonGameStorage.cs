namespace StefansDinner;

public class JsonGameStorage : IGameStorage
{
    private List<IGameStorage> _obj = new List<IGameStorage>();
    public string FileName = "Storage.txt";

    public List<IGameStorage> Load()
    {
        List<IGameStorage> objList = new List<IGameStorage>();

        foreach (var line in File.ReadLines(FileName))
        {
            
        }



        return objList;
    }



    public void Save(List<IDinnerGuest> objList)
    {
        var pop = new Game();
        
        foreach (var obj in objList)
        {

            string outputJSON = Newtonsoft.Json.JsonConvert.SerializeObject(objList,
                Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(FileName, outputJSON + Environment.NewLine);

            //File.AppendAllText(FileName, obj.ToString() + Environment.NewLine);
        }


        //objList.Clear();


    }
}