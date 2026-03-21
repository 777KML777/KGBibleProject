namespace Domain.Dtos;

public record class TrackerDto
(
    DateTime CreatedAt,
    DateTime? CompletedAt,
    DateTime? DeletedAt,
    List<DateTime> UpdateAt
);