﻿using UnityEngine;
using UnityEditor;
using NUnit.Framework;

namespace Framework
{
    public class UITest
    {

        [Test(Description="UIManager 加载测试")]
        public void UIManagerLoadTest()
        {
            RecourcesConfigManager.Initialize();

            GameObject manager = GameObjectManager.CreatGameObject("UIManager");

            Assert.AreNotEqual(manager.GetComponent<UILayerManager>(), null);
            Assert.AreNotEqual(manager.GetComponent<UIAnimManager>(), null);
            Assert.AreNotEqual(manager.GetComponentInChildren<Camera>(), null);
        }
    }
}
