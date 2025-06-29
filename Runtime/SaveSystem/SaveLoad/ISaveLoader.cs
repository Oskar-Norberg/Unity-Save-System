using System.Threading.Tasks;
using ringo.SaveSystem.Subsystem;

namespace ringo.SaveSystem.Managers
{
    public interface ISaveLoader
    {
        public void Save(string fileName, bool overrideSave = false);
        public Task Load(string fileName);
        
        public void RegisterSaveSubsystem(ISaveSubsystem saveSubsystem);
        public void UnregisterSaveSubsystem(ISaveSubsystem saveSubsystem);
    }
}