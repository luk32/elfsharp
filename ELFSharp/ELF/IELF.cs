using System.Collections.Generic;
using ELFSharp.ELF.Sections;
using ELFSharp.ELF.Segments;

namespace ELFSharp.ELF
{
    public interface IELF
    {
        Endianess Endianess { get; }
        Class Class { get; }
        FileType Type { get; }
        Machine Machine { get; }
        bool HasSegmentHeader { get; }
        bool HasSectionHeader { get; }
        bool HasSectionsStringTable { get; }
        IEnumerable<ISegment> Segments { get; }
        IStringTable SectionsStringTable { get; }
        IEnumerable<ISection> Sections { get; }
        IEnumerable<T> GetSections<T>() where T : ISection;
        ISection GetSection(string name);
        ISection GetSection(int index);
    }
}
