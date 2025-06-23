using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class ExaltEverest : BaseMeshEffect
{
    [SerializeField]
    [Range(0, 100)]
    private int _Middle;
    [SerializeField]
    private Color _Upset;
    [SerializeField]
    private float _Magnet;
    [SerializeField]
    private Gradient Shortcut;

    private readonly List<UIVertex> _outlineRussiaName= new List<UIVertex>();
    private readonly List<UIVertex> _CircleName= new List<UIVertex>();

    public override void ModifyMesh(VertexHelper vh)
    {
        if (!IsActive())
            return;

        _CircleName.Clear();
        _outlineRussiaName.Clear();
        vh.GetUIVertexStream(_CircleName);

        var splitAngle = 360f / _Middle;
        UIVertex v;

        var count = _CircleName.Count;
        float c = 0;
        float b = 0;
        for (var i = 0; i < _Middle; i++)
        {
            var angle = splitAngle * i;
            for (var j = 0; j < count; j++)
            {
                v = _CircleName[j];
                var pos = v.position;
                if (pos.y > c)
                    c = pos.y;
                else if (pos.y < b)
                    b = pos.y;
                float fuielementheight = c - b;
                pos.x += Mathf.Cos(angle * Mathf.Deg2Rad) * _Magnet;
                pos.y += Mathf.Sin(angle * Mathf.Deg2Rad) * _Magnet;
                v.position = pos;
                v.color = Shortcut.Evaluate((pos.y- b)/ fuielementheight);
                _outlineRussiaName.Add(v);
            }
        }

        _outlineRussiaName.AddRange(_CircleName);

        vh.Clear();
        vh.AddUIVertexTriangleStream(_outlineRussiaName);
    }
}