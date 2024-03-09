using System.ComponentModel.DataAnnotations.Schema;

namespace WireFrames.Core;

public class WireFrame : BaseWireFrame
{
    public List<WireFrame> Children { get; set; } = [];

    public void AddChild(WireFrame child) => Children.Add(child);
    public void RemoveChild(WireFrame child) => Children.Remove(child);
    public void ClearChildren() => Children.Clear();
}
