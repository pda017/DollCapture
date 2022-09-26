using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAnimator
{
    Animator m_Anim;
    public ZAnimator(GameObject owner)
    {
        m_Anim = owner.GetComponentInChildren<Animator>();
    }
    public void SetEnable(bool bEnable)
    {
        m_Anim.enabled = bEnable;
    }
    public void CrossFade(string aniName, int layer = 0, float normalizeTime = 0,float normalizeDuration = 1)
    {
        m_Anim.CrossFade(aniName, normalizeDuration, layer, normalizeTime);
    }
    public bool IsState(string stateName, int layer = 0)
    {
        return m_Anim.GetCurrentAnimatorStateInfo(layer).IsName(stateName);
    }
    public bool IsPlaying(string aniName,int layer =  0)
    {
        return m_Anim.GetCurrentAnimatorStateInfo(layer).IsName(aniName);
    }
    public void Play(string aniName, int layer = 0, float normalizeTime = 0)
    {
        m_Anim.Play(aniName, layer, normalizeTime);
        m_Anim.Update(0);
    }
    public bool CheckTiming(float normalizeTime,int layer = 0)
    {
        if (normalizeTime >= m_Anim.GetCurrentAnimatorStateInfo(layer).normalizedTime)
            return true;
        return false;
    }
    public bool End(int layer = 0)
    {
        if (m_Anim.GetCurrentAnimatorStateInfo(layer).normalizedTime >= 1f)
            return true;
        return false;
    }
    public void SetSpeed(float speed)
    {
        m_Anim.speed = speed;
    }
    public void SetBool(string key, bool value)
    {
        m_Anim.SetBool(key, value);
    }
    public bool GetBool(string key)
    {
        return m_Anim.GetBool(key);
    }
    public void SetFloat(string key, float value)
    {
        m_Anim.SetFloat(key, value);
    }
    public float GetNormalizeTime(int layer = 0)
    {
        return m_Anim.GetCurrentAnimatorStateInfo(layer).normalizedTime;
    }
    public float GetStateSpeed(int layer = 0)
    {
        return m_Anim.GetCurrentAnimatorStateInfo(layer).speed;
    }
}
