using ErsatzTV.Core.Domain;

namespace ErsatzTV.Application.MediaCards;

public record RemoteStreamCardViewModel(
    int RemoteStreamId,
    string Title,
    string Subtitle,
    string SortTitle,
    string Poster,
    MediaItemState State,
    DateTime DateAdded) : MediaCardViewModel(
    RemoteStreamId,
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
