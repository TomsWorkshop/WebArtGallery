var hoge_plugin = {
  $SensorPermission: {
    initialed: false,

    Init: function ()
    {
      window.addEventListener("deviceorientation", SensorPermission.CheckPermission);
    },

    CheckPermission: function ()
    {
      if (
          DeviceMotionEvent &&
          DeviceMotionEvent.requestPermission &&
          typeof DeviceMotionEvent.requestPermission === 'function'
      ) {
          DeviceMotionEvent.requestPermission();
      }
      if (
          DeviceOrientationEvent &&
          DeviceOrientationEvent.requestPermission &&
          typeof DeviceOrientationEvent.requestPermission === 'function'
      ) {
          DeviceOrientationEvent.requestPermission();
      }
    }

  },

  // Add Event Callback
  DeviceRun: function()
  {
    // hoge_plugin.Init();
    window.alert("Start permission progless.");

    // if (DeviceOrientation.initialed) return;
    // DeviceOrientation.initialed = true;

    // if (
    //   DeviceMotionEvent &&
    //   DeviceMotionEvent.requestPermission &&
    //   typeof DeviceMotionEvent.requestPermission === 'function'
    // ) {
    //     DeviceMotionEvent.requestPermission();
    // }
    // if (
    //     DeviceOrientationEvent &&
    //     DeviceOrientationEvent.requestPermission &&
    //     typeof DeviceOrientationEvent.requestPermission === 'function'
    // ) {
    //     DeviceOrientationEvent.requestPermission();
    //     // <button onclick="requestPermission()">このエリアを押して モーションの利用を許可してください (iOS 13+) </button>
    //     window.alert("DeviceOrientationEvent done.");
    // }

    // DeviceOrientationEvent.requestPermission().then(function () {
    //   // イベントリスナーを登録
    //   window.addEventListener("deviceorientation", function (e) {
    //     // 処理
    //     console.log(e);
    //   }
    // ,0,}).catch(function (e) { console.log(e) });
    
    window.alert("finish !");
  }
};

autoAddDeps(hoge_plugin, '$SensorPermission');
mergeInto(LibraryManager.library, hoge_plugin);