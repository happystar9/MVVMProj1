using CommunityToolkit.Mvvm.Input;
using MVVMProj.Models;

namespace MVVMProj.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}