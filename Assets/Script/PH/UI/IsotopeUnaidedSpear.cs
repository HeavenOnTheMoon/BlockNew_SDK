using UnityEngine;

#if Old_UIFramework
public class IsotopeUnaidedSpear : AlgaUISleek
#elif New_UIFramework
public class IsotopeUnaidedSpear : BaseUI
#else
public class IsotopeUnaidedSpear : MonoBehaviour
#endif
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
