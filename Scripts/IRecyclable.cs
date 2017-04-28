using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IRecyclable
{
    void OnSpawn();

    void OnRecycle();

    void OnReuse();

    void OnDespawn();
}

public enum RecycleState
{
    SPAWN,
    recycle,
    reuse,

}