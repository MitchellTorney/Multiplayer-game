using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitData
{
    public interface IHitResponder
    {
        int Damage {get;}
        public bool CheckHit(HitData data);
        public void Response(HitData data);
    }

    public interface IHitDetector
    {
    public IHitResponder HitResponder {get; set;}
    public void CheckHit();
    }

    public interface IHurtResponder
    {
        public bool CheckHit(HitData data);
        public void Response(HitData data);
    }

    public interface Ihurtbox
    {
        public bool Active{get;}
        public GameObject Owner{get;}
        public Transform Transform{get;}
        public IHurtResponder HurtResponder{get;set;}
        public bool CheckHit(HitData hitData);
    }
}
