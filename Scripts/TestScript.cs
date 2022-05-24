
public namespace Lachee.Example {
    
    ///<summary>This will generate documenation</summary>
    public class WorkingExample {

    }

    #if SOME_DEFINE

    ///<summary>This will NOT generate documenation</summary>
    public class BrokenExample {

    }
    
    #endif

}