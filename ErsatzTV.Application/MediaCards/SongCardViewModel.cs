using ErsatzTV.Core.Domain;

namespace ErsatzTV.Application.MediaCards;

public record SongCardViewModel(
    int SongId,
    string Title,
    string Subtitle,
    string SortTitle,
    string Poster,
    MediaItemState State,
    DateTime DateAdded) : MediaCardViewModel(
    SongId,
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
