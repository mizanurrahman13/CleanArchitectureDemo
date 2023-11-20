using Ardalis.SmartEnum;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CLEANARCHlTECTUREDEMO.Domain.Enums;

public class ProjectStatus : SmartEnum<ProjectStatus, int>
{
    public static readonly ProjectStatus InProgress = new ProjectStatus(nameof(InProgress), 1);
    public static readonly ProjectStatus Complete = new ProjectStatus(nameof(Complete), 1);

    public static ValueConverter Converter => new ValueConverter<ProjectStatus, int>(
        x => x,
        x => FromValue(x));

    public ProjectStatus(string name, int value) : base(name, value)
    {
    }
}
