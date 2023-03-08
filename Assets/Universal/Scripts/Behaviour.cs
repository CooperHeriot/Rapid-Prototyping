
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CH
{
    public class Behaviour : MonoBehaviour
    {
      
        public Color GetRandomColor()
        {
            return new Color(UnityEngine.Random.Range(0.0f, 1.0f), UnityEngine.Random.Range(0.0f, 1.0f), UnityEngine.Random.Range(0.0f, 1.0f));
        }
        /// <summary>
        /// scales a game object to zero immediately
        /// </summary>
        /// <param name="_GO"></param>
        public void ScaleToZero(GameObject _GO)
        {
            _GO.transform.localScale = Vector3.zero;
        }

        public float randoFloat(float min, float max)
        {
            return UnityEngine.Random.Range(min, max);
        }

        public int randoInt(int min, int max)
        {
            return UnityEngine.Random.Range(min, max);
        }

        #region Coroutine Helpers
        // Coroutine helpers
        //
        /// <summary>
        /// Executes the Action block as a Coroutine on the next frame.
        /// </summary>
        /// <param name="func">The Action block</param>
        protected void ExecuteNextFrame(Action func)
        {
            StartCoroutine(ExecuteAfterFramesCoroutine(1, func));
        }
        /// <summary>
        /// Executes the Action block as a Coroutine after X frames.
        /// </summary>
        /// <param name="func">The Action block</param>
        protected void ExecuteAfterFrames(int frames, Action func)
        {
            StartCoroutine(ExecuteAfterFramesCoroutine(frames, func));
        }
        private IEnumerator ExecuteAfterFramesCoroutine(int frames, Action func)
        {
            for (int f = 0; f < frames; f++)
                yield return new WaitForEndOfFrame();
            func();
        }
        /// <summary>
        /// Executes the Action block as a Coroutine after X seconds
        /// </summary>
        /// <param name="seconds">Seconds.</param>
        protected void ExecuteAfterSeconds(float seconds, Action func)
        {
            if (seconds <= 0f)
                func();
            else
                StartCoroutine(ExecuteAfterSecondsCoroutine(seconds, func));
        }
        private IEnumerator ExecuteAfterSecondsCoroutine(float seconds, Action func)
        {
            yield return new WaitForSeconds(seconds);
            func();
        }
        /// <summary>
        /// Executes the Action block as a Coroutine whern a condition is met
        /// </summary>
        /// <param name="condition">The Condition block</param>
        /// <param name="func">The Action block</param>
        protected void ExecuteWhenTrue(Func<bool> condition, Action func)
        {
            StartCoroutine(ExecuteWhenTrueCoroutine(condition, func));
        }
        private IEnumerator ExecuteWhenTrueCoroutine(Func<bool> condition, Action func)
        {
            while (condition() == false)
                yield return new WaitForEndOfFrame();
            func();
        }

        #endregion

        public T RandomEnum<T>()
        {
            var values = Enum.GetValues(typeof(T));
            return (T)values.GetValue(UnityEngine.Random.Range(0, values.Length));
        }
    }

}

