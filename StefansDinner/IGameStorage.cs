namespace StefansDinner;

public interface IGameStorage
{
    
    void Save(List<IDinnerGuest> objList);
    List<IGameStorage> Load();
}