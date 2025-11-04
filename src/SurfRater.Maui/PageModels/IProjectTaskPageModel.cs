using CommunityToolkit.Mvvm.Input;
using SurfRater.Maui.Models;

namespace SurfRater.Maui.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}