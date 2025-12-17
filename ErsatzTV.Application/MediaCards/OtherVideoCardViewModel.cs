using ErsatzTV.Core.Domain;

namespace ErsatzTV.Application.MediaCards;

public record OtherVideoCardViewModel(
    int OtherVideoId,
    string Title,
    string Subtitle,
    string SortTitle,
    string Poster,
    MediaItemState State,
    DateTime DateAdded) : MediaCardViewModel(
    OtherVideoId,
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
