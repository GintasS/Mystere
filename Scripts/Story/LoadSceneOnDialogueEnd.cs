using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Story
{
    public class LoadSceneOnDialogueEnd : MonoBehaviour
    {
        [Header("Wait time after dialogue ends")]
        [SerializeField]
        private int WaitTimeInSeconds;

        public void LoadScene()
        {
            StartCoroutine(Waiter());
        }

        private IEnumerator Waiter()
        {
            //Wait for 4 seconds
            yield return new WaitForSeconds(WaitTimeInSeconds);

            SceneManager.LoadSceneAsync(Constants.Scene.Loading);

        }
    }
}
