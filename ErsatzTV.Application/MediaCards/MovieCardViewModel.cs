using ErsatzTV.Core.Domain;

namespace ErsatzTV.Application.MediaCards;

public record MovieCardViewModel(
    int MovieId,
    string Title,
    string Subtitle,
    string SortTitle,
    string Poster,
    MediaItemState State,
    DateTime DateAdded) : MediaCardViewModel(
    MovieId,
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
