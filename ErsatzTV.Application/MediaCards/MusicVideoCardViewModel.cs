using ErsatzTV.Core.Domain;

namespace ErsatzTV.Application.MediaCards;

public record MusicVideoCardViewModel(
    int MusicVideoId,
    string Title,
    string Subtitle,
    string SortTitle,
    string Plot,
    string Album,
    string Poster,
    MediaItemState State,
    string Path,
    string LocalPath,
    DateTime DateAdded) : MediaCardViewModel(
    MusicVideoId,
    Title,
    Subtitle,
    SortTitle,
    Poster,
    State,
    HasMediaInfo: true,
    DateAdded)
{
    public int CustomIndex { get; set; }
}
