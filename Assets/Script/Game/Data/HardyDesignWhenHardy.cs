using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardyDesignWhenHardy
{
    /// <summary>
    /// 
    /// </summary>
    public List <BlockItem > Block { get; set; }
}

public class BlockItem
{
    /// <summary>
    /// 
    /// </summary>
    public int id { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List <int > shape { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int limit { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int weight { get; set; }
    public int height { get; set; }
    public int widht { get; set; }
    public int count { get; set; }

    public List<int> block { get; set; }
    public int difficulty { get; set; }
}

public class TotalBlockThree
{
    public List <ThreeToThree > ThreeToThree { get; set; }
}
public class ThreeToThree
{
    public int id { get; set; }
    public List <int > layout { get; set; }
    public int weight { get; set; }
}

public class TotalBlockToCheckBoard
{
    public List<BlockToCheckBoard> BlockToCheckBoards { get; set; } 
}

public class ReadBlockToCheckBoard
{
    public string One { get; set; }
    public string Two { get; set; }
    public string Thr { get; set; }
    public string Fou { get; set; }
    public string Fiv { get; set; }
    public string Six { get; set; }
    public string Sev { get; set; }
    public string Eig { get; set; }
    public string Nin { get; set; }
}

public class BlockToCheckBoard
{
    public int Id { get; set; }
    public List<string> OnceBlockInfo { get; set; }
}
