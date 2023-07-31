using Casgem.ObserverDesingPattern.DAL;

namespace Casgem.ObserverDesingPattern.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser user);
    }
}
