/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, { enumerable: true, get: getter });
/******/ 		}
/******/ 	};
/******/
/******/ 	// define __esModule on exports
/******/ 	__webpack_require__.r = function(exports) {
/******/ 		if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 			Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 		}
/******/ 		Object.defineProperty(exports, '__esModule', { value: true });
/******/ 	};
/******/
/******/ 	// create a fake namespace object
/******/ 	// mode & 1: value is a module id, require it
/******/ 	// mode & 2: merge all properties of value into the ns
/******/ 	// mode & 4: return value when already ns object
/******/ 	// mode & 8|1: behave like require
/******/ 	__webpack_require__.t = function(value, mode) {
/******/ 		if(mode & 1) value = __webpack_require__(value);
/******/ 		if(mode & 8) return value;
/******/ 		if((mode & 4) && typeof value === 'object' && value && value.__esModule) return value;
/******/ 		var ns = Object.create(null);
/******/ 		__webpack_require__.r(ns);
/******/ 		Object.defineProperty(ns, 'default', { enumerable: true, value: value });
/******/ 		if(mode & 2 && typeof value != 'string') for(var key in value) __webpack_require__.d(ns, key, function(key) { return value[key]; }.bind(null, key));
/******/ 		return ns;
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "/";
/******/
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(__webpack_require__.s = 1);
/******/ })
/************************************************************************/
/******/ ({

/***/ "./node_modules/@babel/runtime/helpers/classCallCheck.js":
/*!***************************************************************!*\
  !*** ./node_modules/@babel/runtime/helpers/classCallCheck.js ***!
  \***************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function _classCallCheck(instance, Constructor) {
  if (!(instance instanceof Constructor)) {
    throw new TypeError("Cannot call a class as a function");
  }
}

module.exports = _classCallCheck;

/***/ }),

/***/ "./node_modules/@babel/runtime/helpers/createClass.js":
/*!************************************************************!*\
  !*** ./node_modules/@babel/runtime/helpers/createClass.js ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function _defineProperties(target, props) {
  for (var i = 0; i < props.length; i++) {
    var descriptor = props[i];
    descriptor.enumerable = descriptor.enumerable || false;
    descriptor.configurable = true;
    if ("value" in descriptor) descriptor.writable = true;
    Object.defineProperty(target, descriptor.key, descriptor);
  }
}

function _createClass(Constructor, protoProps, staticProps) {
  if (protoProps) _defineProperties(Constructor.prototype, protoProps);
  if (staticProps) _defineProperties(Constructor, staticProps);
  return Constructor;
}

module.exports = _createClass;

/***/ }),

/***/ "./src/js/sokoban.js":
/*!***************************!*\
  !*** ./src/js/sokoban.js ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ./sokoban/start */ "./src/js/sokoban/start.js");

/***/ }),

/***/ "./src/js/sokoban/GameControls.js":
/*!****************************************!*\
  !*** ./src/js/sokoban/GameControls.js ***!
  \****************************************/
/*! exports provided: GameControl */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "GameControl", function() { return GameControl; });
/* harmony import */ var _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @babel/runtime/helpers/classCallCheck */ "./node_modules/@babel/runtime/helpers/classCallCheck.js");
/* harmony import */ var _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @babel/runtime/helpers/createClass */ "./node_modules/@babel/runtime/helpers/createClass.js");
/* harmony import */ var _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _GameEvent__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./GameEvent */ "./src/js/sokoban/GameEvent.js");




var _historyMovement = Symbol();

var _maxMoveCount = Symbol();

var _indexMove = Symbol();

var _currentMoveCount = Symbol();

var _interval = Symbol();

var _isTimeRunning = Symbol();

var _startTimer = Symbol();

var _counter = Symbol();

var _updateTime = Symbol();

var _timeChangeEvent = Symbol();

var _indexMoveChangeEvent = Symbol();

var GameControl =
/*#__PURE__*/
function () {
  function GameControl() {
    _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0___default()(this, GameControl);

    this[_historyMovement] = [];
    this[_maxMoveCount] = 0;
    this[_currentMoveCount] = 0;
    this[_indexMove] = 0;
    this[_counter] = 0;
    this[_isTimeRunning] = false; // Register timeChangeEvent

    this[_timeChangeEvent] = new _GameEvent__WEBPACK_IMPORTED_MODULE_2__["SimpleEvent"]('timeChangeEvent');
    _GameEvent__WEBPACK_IMPORTED_MODULE_2__["GameEvent"].events['timeChangeEvent'] = this[_timeChangeEvent]; // Register indexMoveChangeEvent

    this[_indexMoveChangeEvent] = new _GameEvent__WEBPACK_IMPORTED_MODULE_2__["SimpleEvent"]('indexMoveChangeEvent');
    _GameEvent__WEBPACK_IMPORTED_MODULE_2__["GameEvent"].events['indexMoveChangeEvent'] = this[_indexMoveChangeEvent];
  }

  _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1___default()(GameControl, [{
    key: _updateTime,
    value: function value() {
      this[_counter] += 1;

      if (this[_counter] >= 60) {
        this[_counter] = 0;
        this[_minutes] += 1;
      }

      this[_seconds] = this[_counter];
    }
  }, {
    key: "stopTimer",
    value: function stopTimer() {
      this[_isTimeRunning] = false;
      clearInterval(this[_interval]);
      _GameEvent__WEBPACK_IMPORTED_MODULE_2__["GameEvent"].dispatchEvent('timeChangeEvent');
    }
  }, {
    key: _startTimer,
    value: function value() {
      var _this = this;

      if (this[_isTimeRunning] === true) {
        return;
      }

      this[_isTimeRunning] = true;
      this[_interval] = setInterval(function () {
        _this[_counter] += 1;
        _GameEvent__WEBPACK_IMPORTED_MODULE_2__["GameEvent"].dispatchEvent('timeChangeEvent');
      }, 1000);
    } // get the time

  }, {
    key: "canPlay",
    // check if can navigate throw the (next || previous) moves
    value: function canPlay(moveAmount) {
      var index = moveAmount + this.indexMove;

      if (index > 0 && index < this.maxMoveCount) {
        return true;
      }

      return false;
    } // save the move

  }, {
    key: "saveMove",
    value: function saveMove(movement) {
      // start the timer after the first move
      this[_startTimer](); // remove steps if there is once after the player moved


      this[_historyMovement] = this[_historyMovement].slice(0, this[_indexMove]);

      this[_historyMovement].push(movement);

      this.indexMove += 1;
    } // get a move or moves from the history

  }, {
    key: "getMove",
    value: function getMove(value) {
      var moveIndex = this[_indexMove] + value;

      if (moveIndex < 0) {
        moveIndex = 0;
      } else if (moveIndex > this.maxMoveCount) {
        moveIndex = this.maxMoveCount;
      }

      var startIndex = Math.min(this[_indexMove], moveIndex);
      var endIndex = Math.max(this[_indexMove], moveIndex);
      this.indexMove = moveIndex;

      var array = this[_historyMovement].slice(startIndex, endIndex);

      return array;
    } // reset

  }, {
    key: "reset",
    value: function reset() {
      this[_historyMovement] = [];
      this[_maxMoveCount] = 0;
      this[_currentMoveCount] = 0;
      this.indexMove = 0;
      this[_counter] = 0;
      this.stopTimer();
    }
  }, {
    key: "timeDuration",
    get: function get() {
      var minutes = Math.floor(this[_counter] / 60);
      var seconds = this[_counter] % 60;

      if (seconds < 10) {
        seconds = "0" + seconds;
      }

      if (minutes < 10) {
        minutes = "0" + minutes;
      }

      return "".concat(minutes, ":").concat(seconds);
    } // get the current index move

  }, {
    key: "indexMove",
    get: function get() {
      return this[_indexMove];
    } // set the current index move
    ,
    set: function set(value) {
      this[_indexMove] = value; // trigger the indexMoveChangeEvent

      _GameEvent__WEBPACK_IMPORTED_MODULE_2__["GameEvent"].dispatchEvent('indexMoveChangeEvent');
    } // get the max moves

  }, {
    key: "maxMoveCount",
    get: function get() {
      return this[_historyMovement].length;
    } // get all the moves history

  }, {
    key: "history",
    get: function get() {
      return this[_historyMovement];
    }
  }]);

  return GameControl;
}();

/***/ }),

/***/ "./src/js/sokoban/GameEvent.js":
/*!*************************************!*\
  !*** ./src/js/sokoban/GameEvent.js ***!
  \*************************************/
/*! exports provided: SimpleEvent, GameEvent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SimpleEvent", function() { return SimpleEvent; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "GameEvent", function() { return GameEvent; });
/* harmony import */ var _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @babel/runtime/helpers/classCallCheck */ "./node_modules/@babel/runtime/helpers/classCallCheck.js");
/* harmony import */ var _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @babel/runtime/helpers/createClass */ "./node_modules/@babel/runtime/helpers/createClass.js");
/* harmony import */ var _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1__);


var SimpleEvent =
/*#__PURE__*/
function () {
  function SimpleEvent(name) {
    _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0___default()(this, SimpleEvent);

    this.name = name;
    this.handlers = [];
  }

  _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1___default()(SimpleEvent, [{
    key: "registerHandler",
    value: function registerHandler(handler) {
      this.handlers.push(handler);
    }
  }]);

  return SimpleEvent;
}();
var _events = {};
var GameEvent =
/*#__PURE__*/
function () {
  function GameEvent() {
    _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0___default()(this, GameEvent);
  }

  _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1___default()(GameEvent, null, [{
    key: "registerEvent",
    value: function registerEvent(eventName) {
      var GameEvent = new SimpleEvent(eventName);
      this.events[eventName] = GameEvent;
    }
  }, {
    key: "addEventListener",
    value: function addEventListener(eventName, handler) {
      this.events[eventName].registerHandler(handler);
    }
  }, {
    key: "dispatchEvent",
    value: function dispatchEvent(eventName) {
      this.events[eventName].handlers.forEach(function (callback) {
        callback();
      });
    }
  }, {
    key: "events",
    get: function get() {
      return _events;
    }
  }]);

  return GameEvent;
}();

/***/ }),

/***/ "./src/js/sokoban/Sokoban.js":
/*!***********************************!*\
  !*** ./src/js/sokoban/Sokoban.js ***!
  \***********************************/
/*! exports provided: Sokoban */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "Sokoban", function() { return Sokoban; });
/* harmony import */ var _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @babel/runtime/helpers/classCallCheck */ "./node_modules/@babel/runtime/helpers/classCallCheck.js");
/* harmony import */ var _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @babel/runtime/helpers/createClass */ "./node_modules/@babel/runtime/helpers/createClass.js");
/* harmony import */ var _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _SokobanBase__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./SokobanBase */ "./src/js/sokoban/SokobanBase.js");
/* harmony import */ var _TileGrid__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./TileGrid */ "./src/js/sokoban/TileGrid.js");
/* harmony import */ var _TileGridTable__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./TileGridTable */ "./src/js/sokoban/TileGridTable.js");
/* harmony import */ var _GameControls__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./GameControls */ "./src/js/sokoban/GameControls.js");
/* harmony import */ var _GameEvent__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./GameEvent */ "./src/js/sokoban/GameEvent.js");








var _selectedMap = Symbol();

var _tileGrid = Symbol();

var _renderEngine = Symbol();

var _playMoves = Symbol();

var _gameControl = Symbol();

var Sokoban =
/*#__PURE__*/
function () {
  function Sokoban(width, height) {
    _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0___default()(this, Sokoban);

    this[_selectedMap] = _SokobanBase__WEBPACK_IMPORTED_MODULE_2__["tileMaps"][0];
    this[_tileGrid] = new _TileGrid__WEBPACK_IMPORTED_MODULE_3__["TileGrid"](this[_selectedMap].mapGrid, width, height);
    this[_gameControl] = new _GameControls__WEBPACK_IMPORTED_MODULE_5__["GameControl"]();
  } // apply the movement on the map
  // check for wining


  _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1___default()(Sokoban, [{
    key: _playMoves,
    value: function value(moves) {
      var _this = this;

      moves.forEach(function (move) {
        _this.tileGrid.applyMovement(move);

        _this[_renderEngine].updateTiles(move);
      }); // check for win

      if (this.tileGrid.isGameEnd) {
        _GameEvent__WEBPACK_IMPORTED_MODULE_6__["GameEvent"].dispatchEvent('gameEndEvent');
        this.gameControl.stopTimer();
      }
    } // move the player based on direction
    // save the move

  }, {
    key: "move",
    value: function move(xDirection, yDirection) {
      var move = this.tileGrid.buildMovement(xDirection, yDirection);

      if (move.length > 0 && this.tileGrid.isGameEnd === false) {
        this.gameControl.saveMove(move);

        this[_playMoves]([move]);
      }
    }
  }, {
    key: "playMove",
    // +1, -1, +10, -10
    value: function playMove(value) {
      var moves = this.gameControl.getMove(value);

      if (value < -1) {
        moves.reverse();
      }

      this[_playMoves](moves);
    } // restart the game

  }, {
    key: "restart",
    value: function restart() {
      var tileGridDimension = this[_tileGrid].tileGridDimension;
      this[_tileGrid] = new _TileGrid__WEBPACK_IMPORTED_MODULE_3__["TileGrid"](this[_selectedMap].mapGrid, tileGridDimension, tileGridDimension);
      this.gameControl.reset();
    } // select new tileMap

  }, {
    key: "selectMap",
    value: function selectMap() {
      var selectedMap = arguments.length > 0 && arguments[0] !== undefined ? arguments[0] : 0;
      this[_selectedMap] = _SokobanBase__WEBPACK_IMPORTED_MODULE_2__["tileMaps"][selectedMap];
      this.restart();
    } // change the render engine

  }, {
    key: "setRenderEngine",
    value: function setRenderEngine(renderEngine) {
      switch (renderEngine) {
        case 'divs':
          // change render to divs
          break;

        default:
          // set default to table
          this[_renderEngine] = new _TileGridTable__WEBPACK_IMPORTED_MODULE_4__["TileGridTable"](this.tileGrid);
          break;
      }
    } // drawing the tileMap

  }, {
    key: "createTileMap",
    value: function createTileMap() {
      return this[_renderEngine].createTileMap();
    }
  }, {
    key: "gameControl",
    get: function get() {
      return this[_gameControl];
    }
  }, {
    key: "tileGrid",
    get: function get() {
      return this[_tileGrid];
    }
  }]);

  return Sokoban;
}();

/***/ }),

/***/ "./src/js/sokoban/SokobanBase.js":
/*!***************************************!*\
  !*** ./src/js/sokoban/SokobanBase.js ***!
  \***************************************/
/*! exports provided: tileMaps */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "tileMaps", function() { return tileMaps; });
/*   This is the base file for the Sokoban assignment - include this one in your HTML page, before you add the main script file*/

/*   Enum of CSS Classes for the static elements   */
var Tiles = {
  Wall: "tile-wall",
  Space: "tile-space",
  Goal: "tile-goal"
};
/*   Enum of CSS Classes for the moving elements   */

var Entities = {
  Character: "entity-player",
  Block: "entity-block",
  BlockDone: "entity-block-goal"
};
/*  Legend
  W = Wall
  B = Movable block
  P = Player starting position
  G = Goal area for the blocks
*/

var tileMaps = [{
  name: "Orginal",
  mapGrid: [[[' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' ']], [[' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' ']], [[' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' ']], [[' '], [' '], [' '], [' '], ['W'], ['W'], ['W'], ['W'], ['W'], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' ']], [[' '], [' '], [' '], [' '], ['W'], [' '], [' '], [' '], ['W'], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' ']], [[' '], [' '], [' '], [' '], ['W'], ['B'], [' '], [' '], ['W'], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' ']], [[' '], [' '], ['W'], ['W'], ['W'], [' '], [' '], ['B'], ['W'], ['W'], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' ']], [[' '], [' '], ['W'], [' '], [' '], ['B'], [' '], ['B'], [' '], ['W'], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' ']], [['W'], ['W'], ['W'], [' '], ['W'], [' '], ['W'], ['W'], [' '], ['W'], [' '], [' '], [' '], ['W'], ['W'], ['W'], ['W'], ['W'], ['W']], [['W'], [' '], [' '], [' '], ['W'], [' '], ['W'], ['W'], [' '], ['W'], ['W'], ['W'], ['W'], ['W'], [' '], [' '], ['G'], ['G'], ['W']], [['W'], [' '], ['B'], [' '], [' '], ['B'], [' '], [' '], [' '], [' '], [' '], ['P'], [' '], [' '], [' '], [' '], ['G'], ['G'], ['W']], [['W'], ['W'], ['W'], ['W'], ['W'], [' '], ['W'], ['W'], ['W'], [' '], ['W'], [' '], ['W'], ['W'], [' '], [' '], ['G'], ['G'], ['W']], [[' '], [' '], [' '], [' '], ['W'], [' '], [' '], [' '], [' '], [' '], ['W'], ['W'], ['W'], ['W'], ['W'], ['W'], ['W'], ['W'], ['W']], [[' '], [' '], [' '], [' '], ['W'], ['W'], ['W'], ['W'], ['W'], ['W'], ['W'], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' ']], [[' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' ']], [[' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' ']]]
}, {
  name: "Try It",
  mapGrid: [[['W'], ['W'], [' '], [' '], [' '], [' '], [' '], [' '], [' ']], [['W'], [' '], [' '], ['W'], ['W'], [' '], [' '], [' '], [' ']], [[' '], ['B'], [' '], ['G'], [' '], [' '], [' '], [' '], [' ']], [[' '], [' '], [' '], ['G'], [' '], [' '], [' '], [' '], [' ']], [['W'], [' '], ['P'], ['G'], [' '], [' '], [' '], [' '], [' ']], [['W'], [' '], ['W'], ['W'], ['W'], [' '], [' '], ['B'], [' ']], [[' '], ['B'], [' '], [' '], [' '], [' '], [' '], [' '], [' ']], [[' '], [' '], [' '], [' '], [' '], [' '], [' '], [' '], [' ']]]
}, {
  name: "Is it imposible!",
  mapGrid: [[[' '], ['P'], [' '], [' '], [' ']], [[' '], [' '], [' '], ['B'], [' ']], [[' '], [' '], [' '], [' '], [' ']], [[' '], ['B'], [' '], [' '], [' ']], [['G'], [' '], ['G'], [' '], [' ']]]
}];

/***/ }),

/***/ "./src/js/sokoban/Tile.js":
/*!********************************!*\
  !*** ./src/js/sokoban/Tile.js ***!
  \********************************/
/*! exports provided: Tile */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "Tile", function() { return Tile; });
/* harmony import */ var _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @babel/runtime/helpers/classCallCheck */ "./node_modules/@babel/runtime/helpers/classCallCheck.js");
/* harmony import */ var _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @babel/runtime/helpers/createClass */ "./node_modules/@babel/runtime/helpers/createClass.js");
/* harmony import */ var _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1__);



var _tileImage = Symbol();

var _hostImage = Symbol();

var _initialzeTile = Symbol();

var _hostType = Symbol();

var _type = Symbol();

var _updateTileImage = Symbol();

var Tile =
/*#__PURE__*/
function () {
  function Tile(type, row, column) {
    _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0___default()(this, Tile);

    this.row = row;
    this.column = column;
    this[_hostImage] = ' ';

    this[_initialzeTile](type);
  } // the type of the tile never gonna change


  _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1___default()(Tile, [{
    key: _initialzeTile,
    value: function value(type) {
      if (type === 'G') {
        this[_type] = 'G';
        this.hostType = ' ';
      } else if (type === 'W') {
        this[_type] = 'W';
        this.hostType = 'W';
      } else if (type === 'B') {
        this[_type] = ' ';
        this.hostType = 'B';
      } else if (type === 'P') {
        this[_type] = ' ';
        this.hostType = 'P';
      } else {
        this[_type] = ' ';
        this.hostType = ' ';
      }
    }
  }, {
    key: _updateTileImage,
    value: function value() {
      var type = this[_hostType] !== ' ' ? this[_hostType] : this[_type];

      switch (type) {
        case 'W':
          this[_tileImage] = 'wall.png';
          break;

        case 'B':
          this[_tileImage] = this[_type] === 'G' ? "correct_box.png" : "box.png";
          break;

        case 'P':
          this[_tileImage] = 'player.png';
          break;

        case 'G':
          this[_tileImage] = 'goal.png';
          break;

        default:
          this[_tileImage] = 'emptyTile.png';
          break;
      }
    }
  }, {
    key: "type",
    get: function get() {
      return this[_type];
    } // the hostType is value('P' | 'B' | ' ') that the tile is holding

  }, {
    key: "hostType",
    set: function set(hostType) {
      this[_hostType] = hostType; // after the hostType change update the tile image

      this[_updateTileImage]();
    } // get the hostType of the tile
    ,
    get: function get() {
      return this[_hostType];
    } // get the image of hostType becouse thats what it will be render

  }, {
    key: "tileImage",
    get: function get() {
      return this[_tileImage];
    } // check if this cell can contain a hostType

  }, {
    key: "canContainHost",
    get: function get() {
      return this[_hostType] === ' ';
    }
  }]);

  return Tile;
}();

/***/ }),

/***/ "./src/js/sokoban/TileGrid.js":
/*!************************************!*\
  !*** ./src/js/sokoban/TileGrid.js ***!
  \************************************/
/*! exports provided: TileGrid */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TileGrid", function() { return TileGrid; });
/* harmony import */ var _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @babel/runtime/helpers/classCallCheck */ "./node_modules/@babel/runtime/helpers/classCallCheck.js");
/* harmony import */ var _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @babel/runtime/helpers/createClass */ "./node_modules/@babel/runtime/helpers/createClass.js");
/* harmony import */ var _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _Tile__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./Tile */ "./src/js/sokoban/Tile.js");
/* harmony import */ var _GameEvent__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./GameEvent */ "./src/js/sokoban/GameEvent.js");





var _tileGrid = Symbol();

var _createTileMap = Symbol();

var _rows = Symbol();

var _columns = Symbol();

var _tileGridDimension = Symbol();

var _tileDimensionInPrecent = Symbol();

var _calculateTileDimensionInPrecent = Symbol();

var _playerX = Symbol();

var _playerY = Symbol();

var _goalTiles = Symbol();

var _gameEndEvent = Symbol();

var TileGrid =
/*#__PURE__*/
function () {
  function TileGrid(tileGrid, tileGridWidth) {
    var tileGridHeight = arguments.length > 2 && arguments[2] !== undefined ? arguments[2] : 0;

    _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0___default()(this, TileGrid);

    this[_tileGrid] = this[_createTileMap](tileGrid);
    this[_rows] = this[_tileGrid].length;
    this[_columns] = this[_tileGrid][0].length;
    this[_tileGridDimension] = Math.min(tileGridWidth, tileGridHeight);
    this[_tileDimensionInPrecent] = this[_calculateTileDimensionInPrecent]();
    this[_gameEndEvent] = new _GameEvent__WEBPACK_IMPORTED_MODULE_3__["SimpleEvent"]('gameEndEvent');
    _GameEvent__WEBPACK_IMPORTED_MODULE_3__["GameEvent"].events['gameEndEvent'] = this[_gameEndEvent];
  } // fill in the grid with tiles and set the starter point


  _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1___default()(TileGrid, [{
    key: _createTileMap,
    value: function value(tileGrid) {
      var tileMap = [];
      this[_goalTiles] = [];

      for (var i = 0; i < tileGrid.length; i++) {
        var columns = [];

        for (var j = 0; j < tileGrid[i].length; j++) {
          var tile = new _Tile__WEBPACK_IMPORTED_MODULE_2__["Tile"](tileGrid[i][j][0], i, j);

          if (tileGrid[i][j][0] === 'P') {
            this[_playerX] = i;
            this[_playerY] = j;
          } else if (tileGrid[i][j][0] === 'G') {
            this[_goalTiles].push(tile);
          }

          columns.push(tile);
        }

        tileMap.push(columns);
      }

      return tileMap;
    } // calculate how mush space each tile will take based on the grid (height || width)

  }, {
    key: _calculateTileDimensionInPrecent,
    value: function value() {
      var tileMapRib = Math.max(this[_rows], this[_columns]);
      var tileDimension = this[_tileGridDimension] / tileMapRib;
      var tileMapDimensionInPrecent = tileDimension / this[_tileGridDimension] * 100;
      return tileMapDimensionInPrecent;
    } // get the grid that contain all the tiles

  }, {
    key: "updateTileGridDimension",
    // update the deminsion of the map
    value: function updateTileGridDimension(height, width) {
      // to maintain the aspect ratio of the map we take the smallest
      this[_tileGridDimension] = Math.min(height, width);
    } // return list of tiles("movements") from the start point "player" to the direction.
    // direction could be 'top, right, bottom, left'.
    // if return [] direction is blocked or out of range

  }, {
    key: "buildMovement",
    value: function buildMovement(xDirection, yDirection) {
      var startX = arguments.length > 2 && arguments[2] !== undefined ? arguments[2] : this[_playerX];
      var startY = arguments.length > 3 && arguments[3] !== undefined ? arguments[3] : this[_playerY];
      var previousMovement = arguments.length > 4 && arguments[4] !== undefined ? arguments[4] : [];
      var xTarget = startX + xDirection;
      var yTarget = startY + yDirection; // Check if the target location is inside the grid

      if (xTarget < 0 || xTarget >= this[_tileGrid].length || yTarget < 0 || yTarget >= this[_tileGrid][xTarget].length) {
        return [];
      }

      var tile = this[_tileGrid][startX][startY];
      var nextTile = this[_tileGrid][xTarget][yTarget]; // if target is wall don't move

      if (nextTile.type === 'W') return []; // when we have two boxes

      if (tile.hostType === 'B' && nextTile.hostType === 'B') return []; // if the target is empty and doesn't contain a tile
      else if (nextTile.type === ' ' && nextTile.canContainHost === true) {
          previousMovement.push(tile);
          previousMovement.push(nextTile);
          return previousMovement;
        } // if the target is correct and doesn't contain a tile
        else if (nextTile.type === 'G' && nextTile.canContainHost === true) {
            previousMovement.push(tile);
            previousMovement.push(nextTile);
            return previousMovement;
          } // target is crate check if the crate can move
          else {
              previousMovement.push(tile);
              return this.buildMovement(xDirection, yDirection, xTarget, yTarget, previousMovement);
            }
    } // update the tiles based on list of movement
    // args:
    //  movement: list of tiles that need to be change after the player moved

  }, {
    key: "applyMovement",
    value: function applyMovement(movement) {
      // when we play the move backword
      // becouse the move start from left to right
      if (movement[0].hostType !== ' ') {
        movement.reverse();
      } // loop throw the moves and shift theme toword the empty tile


      for (var i = 0; i < movement.length - 1; i++) {
        var tile = movement[i];
        var targetTile = movement[i + 1];
        var tileHostTypeCopy = targetTile.hostType; // Switch the two tiles from the left to right

        targetTile.hostType = tile.hostType;
        tile.hostType = tileHostTypeCopy;
      } // update the starter point "player"
      // calculate the direction after the starter point changed


      var playerTile = movement.filter(function (tile) {
        return tile.hostType === 'P';
      })[0];
      this[_playerX] = playerTile.row;
      this[_playerY] = playerTile.column;
    }
  }, {
    key: "tiles",
    get: function get() {
      return this[_tileGrid];
    } // get the grid dimension

  }, {
    key: "tileGridDimension",
    get: function get() {
      return this[_tileGridDimension];
    } // get the tile dimension

  }, {
    key: "tileDimensionInPrecent",
    get: function get() {
      return this[_tileDimensionInPrecent];
    } // Check if the game ended
    // Return: boolean

  }, {
    key: "isGameEnd",
    get: function get() {
      return this[_goalTiles].filter(function (t) {
        return t.hostType !== 'B';
      }).length === 0;
    }
  }]);

  return TileGrid;
}();

/***/ }),

/***/ "./src/js/sokoban/TileGridTable.js":
/*!*****************************************!*\
  !*** ./src/js/sokoban/TileGridTable.js ***!
  \*****************************************/
/*! exports provided: TileGridTable */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TileGridTable", function() { return TileGridTable; });
/* harmony import */ var _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @babel/runtime/helpers/classCallCheck */ "./node_modules/@babel/runtime/helpers/classCallCheck.js");
/* harmony import */ var _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @babel/runtime/helpers/createClass */ "./node_modules/@babel/runtime/helpers/createClass.js");
/* harmony import */ var _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _GameEvent__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./GameEvent */ "./src/js/sokoban/GameEvent.js");




var _table = Symbol();

var _updateCellImage = Symbol();

var _tileGrid = Symbol();

var TileGridTable =
/*#__PURE__*/
function () {
  function TileGridTable(tileGrid) {
    var _this = this;

    _babel_runtime_helpers_classCallCheck__WEBPACK_IMPORTED_MODULE_0___default()(this, TileGridTable);

    this[_tileGrid] = tileGrid;
    _GameEvent__WEBPACK_IMPORTED_MODULE_2__["GameEvent"].addEventListener('gameEndEvent', function () {
      _this[_table].style.borderColor = '#008000';
    });
  } // the grid will be table cells with images


  _babel_runtime_helpers_createClass__WEBPACK_IMPORTED_MODULE_1___default()(TileGridTable, [{
    key: "createTileMap",
    value: function createTileMap() {
      var tableGrid = document.createElement('table'); // Create the table body (rows, columns)

      for (var i = 0; i < this[_tileGrid].tiles.length; i++) {
        var tr = document.createElement('tr');

        for (var j = 0; j < this[_tileGrid].tiles[i].length; j++) {
          var td = document.createElement('td');
          var tile = document.createElement('img');
          tile.src = "/images/sokoban/".concat(this[_tileGrid].tiles[i][j].tileImage);
          td.style.width = this[_tileGrid].tileDimensionInPrecent + '%';
          td.style.height = this[_tileGrid].tileDimensionInPrecent + '%';
          td.appendChild(tile);
          tr.appendChild(td);
        }

        tableGrid.appendChild(tr);
      }

      tableGrid.style.border = '2px solid #FFC107';
      this[_table] = tableGrid;
      return this[_table];
    } // sync the tile grid and table cell

  }, {
    key: "updateTiles",
    value: function updateTiles(tiles) {
      var _this2 = this;

      tiles.forEach(function (tile) {
        _this2[_updateCellImage](tile);
      });
    } // updatet the cell

  }, {
    key: _updateCellImage,
    value: function value(tile) {
      var tileImage = this[_table].rows[tile.row].cells.item(tile.column).firstChild;

      tileImage.src = "/images/sokoban/".concat(tile.tileImage);
    }
  }]);

  return TileGridTable;
}();

/***/ }),

/***/ "./src/js/sokoban/start.js":
/*!*********************************!*\
  !*** ./src/js/sokoban/start.js ***!
  \*********************************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _Sokoban__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./Sokoban */ "./src/js/sokoban/Sokoban.js");
/* harmony import */ var _GameEvent__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./GameEvent */ "./src/js/sokoban/GameEvent.js");

 // #region Dom elements

var gridRender = document.getElementById('gridRenderingEnginesId');
var gridRenderEngines = gridRender.getElementsByTagName('button');
var gameContainer = document.getElementById('gameContainerId');
var renderContainer = document.getElementById('renderContainerId');
var renderEngine = document.getElementById('renderEngineId');
var levelSelect = document.getElementById('levelSelectId');
var movesHistoryButtons = document.getElementById('movesHistoryButtonsId').getElementsByTagName('button');
var restartButton = document.getElementById('restartButtonId');
var movementIndex = document.getElementById('movementIndexId');
var time = document.getElementById('timeId'); // #endregion
// variable to keep track the height and width of the tileMap and the selected rendering

var gridHeight = (document.documentElement.clientHeight, window.innerHeight || 0);
var gridWidth = renderContainer.clientWidth;
var selectedRenderingEngine = "table"; // Initial Table Grid

var sokoban = new _Sokoban__WEBPACK_IMPORTED_MODULE_0__["Sokoban"](gridWidth, gridHeight); // default to tableRendering

render(selectedRenderingEngine); // Add event when level is changed

levelSelect.addEventListener('change', function () {
  sokoban.selectMap(levelSelect.value);
  render(selectedRenderingEngine);
}); // Add click event for each rendering engine

var _loop = function _loop(i) {
  gridRenderEngines[i].addEventListener('click', function () {
    var renderingEngine = gridRenderEngines[i].getAttribute("toggle-rendering");

    if (renderingEngine !== selectedRenderingEngine) {
      // Remove active class from the old render engine
      gridRender.querySelector("[toggle-rendering=\"".concat(selectedRenderingEngine, "\"]")).classList.remove('active'); // Add active class to the new rendering engine

      gridRenderEngines[i].classList.add('active'); // Update the selected rendering engine

      selectedRenderingEngine = renderingEngine;
      sokoban.setRenderEngine(selectedRenderingEngine);
    }
  });
};

for (var i = 0; i < gridRenderEngines.length; i++) {
  _loop(i);
} // Add click event for the moves buttons


var _loop2 = function _loop2(i) {
  movesHistoryButtons[i].addEventListener('click', function () {
    var moveAmount = movesHistoryButtons[i].getAttribute("move-amount");
    sokoban.playMove(parseInt(moveAmount));
    movementIndex.innerText = sokoban.gameControl.indexMove;
  });
};

for (var i = 0; i < movesHistoryButtons.length; i++) {
  _loop2(i);
} // Update the render engine dimension when resize


window.addEventListener('resize', function () {
  gridHeight = (document.documentElement.clientHeight, window.innerHeight || 0);
  gridWidth = renderContainer.clientWidth;
  sokoban.tileGrid.updateTileGridDimension(gridHeight, gridWidth);
  setRenderEngineDimension();
}, true); // key event only for the game board

gameContainer.addEventListener('keydown', function (e) {
  captureKey(e);
}); // Restart Button

restartButton.addEventListener('click', function () {
  sokoban.restart();
  render(selectedRenderingEngine);
}); // Update Time

_GameEvent__WEBPACK_IMPORTED_MODULE_1__["GameEvent"].addEventListener('timeChangeEvent', function () {
  time.innerText = sokoban.gameControl.timeDuration;
});
_GameEvent__WEBPACK_IMPORTED_MODULE_1__["GameEvent"].addEventListener('indexMoveChangeEvent', function () {
  movementIndex.innerText = sokoban.gameControl.indexMove;
}); // Focus on the grid to recive key input after page load

window.addEventListener('load', function () {
  gameContainer.focus(); // preload the image

  new Image().src = "/images/sokoban/correct_box.png";
}); // Map the keyboard keys to direction

function captureKey(keyBoardEvent) {
  keyBoardEvent.preventDefault();

  switch (keyBoardEvent.keyCode) {
    // left
    case 37:
      sokoban.move(0, -1);
      break;
    // top

    case 38:
      sokoban.move(-1, 0);
      break;
    // right

    case 39:
      sokoban.move(0, 1);
      break;
    // bottom

    case 40:
      sokoban.move(1, 0);
      break;

    default:
      break;
  }
} // Draw the tileMap


function render(renderingEngine) {
  sokoban.setRenderEngine(renderingEngine); // clear the previouse render

  renderEngine.innerHTML = ""; // create the table grid

  var tileMap = sokoban.createTileMap(); // add the new render

  renderEngine.appendChild(tileMap); // set the width and height of the render

  setRenderEngineDimension();
} // Set the width and height of the tileMap


function setRenderEngineDimension() {
  renderEngine.style.width = sokoban.tileGrid.tileGridDimension + 'px';
}

/***/ }),

/***/ "./src/sass/projects/sokoban.scss":
/*!****************************************!*\
  !*** ./src/sass/projects/sokoban.scss ***!
  \****************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__.p + "css/sokoban.css";

/***/ }),

/***/ 1:
/*!******************************************************************!*\
  !*** multi ./src/js/sokoban.js ./src/sass/projects/sokoban.scss ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! ./src/js/sokoban.js */"./src/js/sokoban.js");
module.exports = __webpack_require__(/*! ./src/sass/projects/sokoban.scss */"./src/sass/projects/sokoban.scss");


/***/ })

/******/ });
//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIndlYnBhY2s6Ly8vd2VicGFjay9ib290c3RyYXAiLCJ3ZWJwYWNrOi8vLy4vbm9kZV9tb2R1bGVzL0BiYWJlbC9ydW50aW1lL2hlbHBlcnMvY2xhc3NDYWxsQ2hlY2suanMiLCJ3ZWJwYWNrOi8vLy4vbm9kZV9tb2R1bGVzL0BiYWJlbC9ydW50aW1lL2hlbHBlcnMvY3JlYXRlQ2xhc3MuanMiLCJ3ZWJwYWNrOi8vLy4vc3JjL2pzL3Nva29iYW4uanMiLCJ3ZWJwYWNrOi8vLy4vc3JjL2pzL3Nva29iYW4vR2FtZUNvbnRyb2xzLmpzIiwid2VicGFjazovLy8uL3NyYy9qcy9zb2tvYmFuL0dhbWVFdmVudC5qcyIsIndlYnBhY2s6Ly8vLi9zcmMvanMvc29rb2Jhbi9Tb2tvYmFuLmpzIiwid2VicGFjazovLy8uL3NyYy9qcy9zb2tvYmFuL1Nva29iYW5CYXNlLmpzIiwid2VicGFjazovLy8uL3NyYy9qcy9zb2tvYmFuL1RpbGUuanMiLCJ3ZWJwYWNrOi8vLy4vc3JjL2pzL3Nva29iYW4vVGlsZUdyaWQuanMiLCJ3ZWJwYWNrOi8vLy4vc3JjL2pzL3Nva29iYW4vVGlsZUdyaWRUYWJsZS5qcyIsIndlYnBhY2s6Ly8vLi9zcmMvanMvc29rb2Jhbi9zdGFydC5qcyIsIndlYnBhY2s6Ly8vLi9zcmMvc2Fzcy9wcm9qZWN0cy9zb2tvYmFuLnNjc3MiXSwibmFtZXMiOlsicmVxdWlyZSIsIl9oaXN0b3J5TW92ZW1lbnQiLCJTeW1ib2wiLCJfbWF4TW92ZUNvdW50IiwiX2luZGV4TW92ZSIsIl9jdXJyZW50TW92ZUNvdW50IiwiX2ludGVydmFsIiwiX2lzVGltZVJ1bm5pbmciLCJfc3RhcnRUaW1lciIsIl9jb3VudGVyIiwiX3VwZGF0ZVRpbWUiLCJfdGltZUNoYW5nZUV2ZW50IiwiX2luZGV4TW92ZUNoYW5nZUV2ZW50IiwiR2FtZUNvbnRyb2wiLCJTaW1wbGVFdmVudCIsIkdhbWVFdmVudCIsImV2ZW50cyIsIl9taW51dGVzIiwiX3NlY29uZHMiLCJjbGVhckludGVydmFsIiwiZGlzcGF0Y2hFdmVudCIsInNldEludGVydmFsIiwibW92ZUFtb3VudCIsImluZGV4IiwiaW5kZXhNb3ZlIiwibWF4TW92ZUNvdW50IiwibW92ZW1lbnQiLCJzbGljZSIsInB1c2giLCJ2YWx1ZSIsIm1vdmVJbmRleCIsInN0YXJ0SW5kZXgiLCJNYXRoIiwibWluIiwiZW5kSW5kZXgiLCJtYXgiLCJhcnJheSIsInN0b3BUaW1lciIsIm1pbnV0ZXMiLCJmbG9vciIsInNlY29uZHMiLCJsZW5ndGgiLCJuYW1lIiwiaGFuZGxlcnMiLCJoYW5kbGVyIiwiX2V2ZW50cyIsImV2ZW50TmFtZSIsInJlZ2lzdGVySGFuZGxlciIsImZvckVhY2giLCJjYWxsYmFjayIsIl9zZWxlY3RlZE1hcCIsIl90aWxlR3JpZCIsIl9yZW5kZXJFbmdpbmUiLCJfcGxheU1vdmVzIiwiX2dhbWVDb250cm9sIiwiU29rb2JhbiIsIndpZHRoIiwiaGVpZ2h0IiwidGlsZU1hcHMiLCJUaWxlR3JpZCIsIm1hcEdyaWQiLCJtb3ZlcyIsIm1vdmUiLCJ0aWxlR3JpZCIsImFwcGx5TW92ZW1lbnQiLCJ1cGRhdGVUaWxlcyIsImlzR2FtZUVuZCIsImdhbWVDb250cm9sIiwieERpcmVjdGlvbiIsInlEaXJlY3Rpb24iLCJidWlsZE1vdmVtZW50Iiwic2F2ZU1vdmUiLCJnZXRNb3ZlIiwicmV2ZXJzZSIsInRpbGVHcmlkRGltZW5zaW9uIiwicmVzZXQiLCJzZWxlY3RlZE1hcCIsInJlc3RhcnQiLCJyZW5kZXJFbmdpbmUiLCJUaWxlR3JpZFRhYmxlIiwiY3JlYXRlVGlsZU1hcCIsIlRpbGVzIiwiV2FsbCIsIlNwYWNlIiwiR29hbCIsIkVudGl0aWVzIiwiQ2hhcmFjdGVyIiwiQmxvY2siLCJCbG9ja0RvbmUiLCJfdGlsZUltYWdlIiwiX2hvc3RJbWFnZSIsIl9pbml0aWFsemVUaWxlIiwiX2hvc3RUeXBlIiwiX3R5cGUiLCJfdXBkYXRlVGlsZUltYWdlIiwiVGlsZSIsInR5cGUiLCJyb3ciLCJjb2x1bW4iLCJob3N0VHlwZSIsIl9jcmVhdGVUaWxlTWFwIiwiX3Jvd3MiLCJfY29sdW1ucyIsIl90aWxlR3JpZERpbWVuc2lvbiIsIl90aWxlRGltZW5zaW9uSW5QcmVjZW50IiwiX2NhbGN1bGF0ZVRpbGVEaW1lbnNpb25JblByZWNlbnQiLCJfcGxheWVyWCIsIl9wbGF5ZXJZIiwiX2dvYWxUaWxlcyIsIl9nYW1lRW5kRXZlbnQiLCJ0aWxlR3JpZFdpZHRoIiwidGlsZUdyaWRIZWlnaHQiLCJ0aWxlTWFwIiwiaSIsImNvbHVtbnMiLCJqIiwidGlsZSIsInRpbGVNYXBSaWIiLCJ0aWxlRGltZW5zaW9uIiwidGlsZU1hcERpbWVuc2lvbkluUHJlY2VudCIsInN0YXJ0WCIsInN0YXJ0WSIsInByZXZpb3VzTW92ZW1lbnQiLCJ4VGFyZ2V0IiwieVRhcmdldCIsIm5leHRUaWxlIiwiY2FuQ29udGFpbkhvc3QiLCJ0YXJnZXRUaWxlIiwidGlsZUhvc3RUeXBlQ29weSIsInBsYXllclRpbGUiLCJmaWx0ZXIiLCJ0IiwiX3RhYmxlIiwiX3VwZGF0ZUNlbGxJbWFnZSIsImFkZEV2ZW50TGlzdGVuZXIiLCJzdHlsZSIsImJvcmRlckNvbG9yIiwidGFibGVHcmlkIiwiZG9jdW1lbnQiLCJjcmVhdGVFbGVtZW50IiwidGlsZXMiLCJ0ciIsInRkIiwic3JjIiwidGlsZUltYWdlIiwidGlsZURpbWVuc2lvbkluUHJlY2VudCIsImFwcGVuZENoaWxkIiwiYm9yZGVyIiwicm93cyIsImNlbGxzIiwiaXRlbSIsImZpcnN0Q2hpbGQiLCJncmlkUmVuZGVyIiwiZ2V0RWxlbWVudEJ5SWQiLCJncmlkUmVuZGVyRW5naW5lcyIsImdldEVsZW1lbnRzQnlUYWdOYW1lIiwiZ2FtZUNvbnRhaW5lciIsInJlbmRlckNvbnRhaW5lciIsImxldmVsU2VsZWN0IiwibW92ZXNIaXN0b3J5QnV0dG9ucyIsInJlc3RhcnRCdXR0b24iLCJtb3ZlbWVudEluZGV4IiwidGltZSIsImdyaWRIZWlnaHQiLCJkb2N1bWVudEVsZW1lbnQiLCJjbGllbnRIZWlnaHQiLCJ3aW5kb3ciLCJpbm5lckhlaWdodCIsImdyaWRXaWR0aCIsImNsaWVudFdpZHRoIiwic2VsZWN0ZWRSZW5kZXJpbmdFbmdpbmUiLCJzb2tvYmFuIiwicmVuZGVyIiwic2VsZWN0TWFwIiwicmVuZGVyaW5nRW5naW5lIiwiZ2V0QXR0cmlidXRlIiwicXVlcnlTZWxlY3RvciIsImNsYXNzTGlzdCIsInJlbW92ZSIsImFkZCIsInNldFJlbmRlckVuZ2luZSIsInBsYXlNb3ZlIiwicGFyc2VJbnQiLCJpbm5lclRleHQiLCJ1cGRhdGVUaWxlR3JpZERpbWVuc2lvbiIsInNldFJlbmRlckVuZ2luZURpbWVuc2lvbiIsImUiLCJjYXB0dXJlS2V5IiwidGltZUR1cmF0aW9uIiwiZm9jdXMiLCJJbWFnZSIsImtleUJvYXJkRXZlbnQiLCJwcmV2ZW50RGVmYXVsdCIsImtleUNvZGUiLCJpbm5lckhUTUwiXSwibWFwcGluZ3MiOiI7QUFBQTtBQUNBOztBQUVBO0FBQ0E7O0FBRUE7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7O0FBRUE7QUFDQTs7QUFFQTtBQUNBOztBQUVBO0FBQ0E7QUFDQTs7O0FBR0E7QUFDQTs7QUFFQTtBQUNBOztBQUVBO0FBQ0E7QUFDQTtBQUNBLGtEQUEwQyxnQ0FBZ0M7QUFDMUU7QUFDQTs7QUFFQTtBQUNBO0FBQ0E7QUFDQSxnRUFBd0Qsa0JBQWtCO0FBQzFFO0FBQ0EseURBQWlELGNBQWM7QUFDL0Q7O0FBRUE7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBLGlEQUF5QyxpQ0FBaUM7QUFDMUUsd0hBQWdILG1CQUFtQixFQUFFO0FBQ3JJO0FBQ0E7O0FBRUE7QUFDQTtBQUNBO0FBQ0EsbUNBQTJCLDBCQUEwQixFQUFFO0FBQ3ZELHlDQUFpQyxlQUFlO0FBQ2hEO0FBQ0E7QUFDQTs7QUFFQTtBQUNBLDhEQUFzRCwrREFBK0Q7O0FBRXJIO0FBQ0E7OztBQUdBO0FBQ0E7Ozs7Ozs7Ozs7OztBQ2xGQTtBQUNBO0FBQ0E7QUFD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bmRsZS5qcyIsInNvdXJjZXNDb250ZW50IjpbIiBcdC8vIFRoZSBtb2R1bGUgY2FjaGVcbiBcdHZhciBpbnN0YWxsZWRNb2R1bGVzID0ge307XG5cbiBcdC8vIFRoZSByZXF1aXJlIGZ1bmN0aW9uXG4gXHRmdW5jdGlvbiBfX3dlYnBhY2tfcmVxdWlyZV9fKG1vZHVsZUlkKSB7XG5cbiBcdFx0Ly8gQ2hlY2sgaWYgbW9kdWxlIGlzIGluIGNhY2hlXG4gXHRcdGlmKGluc3RhbGxlZE1vZHVsZXNbbW9kdWxlSWRdKSB7XG4gXHRcdFx0cmV0dXJuIGluc3RhbGxlZE1vZHVsZXNbbW9kdWxlSWRdLmV4cG9ydHM7XG4gXHRcdH1cbiBcdFx0Ly8gQ3JlYXRlIGEgbmV3IG1vZHVsZSAoYW5kIHB1dCBpdCBpbnRvIHRoZSBjYWNoZSlcbiBcdFx0dmFyIG1vZHVsZSA9IGluc3RhbGxlZE1vZHVsZXNbbW9kdWxlSWRdID0ge1xuIFx0XHRcdGk6IG1vZHVsZUlkLFxuIFx0XHRcdGw6IGZhbHNlLFxuIFx0XHRcdGV4cG9ydHM6IHt9XG4gXHRcdH07XG5cbiBcdFx0Ly8gRXhlY3V0ZSB0aGUgbW9kdWxlIGZ1bmN0aW9uXG4gXHRcdG1vZHVsZXNbbW9kdWxlSWRdLmNhbGwobW9kdWxlLmV4cG9ydHMsIG1vZHVsZSwgbW9kdWxlLmV4cG9ydHMsIF9fd2VicGFja19yZXF1aXJlX18pO1xuXG4gXHRcdC8vIEZsYWcgdGhlIG1vZHVsZSBhcyBsb2FkZWRcbiBcdFx0bW9kdWxlLmwgPSB0cnVlO1xuXG4gXHRcdC8vIFJldHVybiB0aGUgZXhwb3J0cyBvZiB0aGUgbW9kdWxlXG4gXHRcdHJldHVybiBtb2R1bGUuZXhwb3J0cztcbiBcdH1cblxuXG4gXHQvLyBleHBvc2UgdGhlIG1vZHVsZXMgb2JqZWN0IChfX3dlYnBhY2tfbW9kdWxlc19fKVxuIFx0X193ZWJwYWNrX3JlcXVpcmVfXy5tID0gbW9kdWxlcztcblxuIFx0Ly8gZXhwb3NlIHRoZSBtb2R1bGUgY2FjaGVcbiBcdF9fd2VicGFja19yZXF1aXJlX18uYyA9IGluc3RhbGxlZE1vZHVsZXM7XG5cbiBcdC8vIGRlZmluZSBnZXR0ZXIgZnVuY3Rpb24gZm9yIGhhcm1vbnkgZXhwb3J0c1xuIFx0X193ZWJwYWNrX3JlcXVpcmVfXy5kID0gZnVuY3Rpb24oZXhwb3J0cywgbmFtZSwgZ2V0dGVyKSB7XG4gXHRcdGlmKCFfX3dlYnBhY2tfcmVxdWlyZV9fLm8oZXhwb3J0cywgbmFtZSkpIHtcbiBcdFx0XHRPYmplY3QuZGVmaW5lUHJvcGVydHkoZXhwb3J0cywgbmFtZSwgeyBlbnVtZXJhYmxlOiB0cnVlLCBnZXQ6IGdldHRlciB9KTtcbiBcdFx0fVxuIFx0fTtcblxuIFx0Ly8gZGVmaW5lIF9fZXNNb2R1bGUgb24gZXhwb3J0c1xuIFx0X193ZWJwYWNrX3JlcXVpcmVfXy5yID0gZnVuY3Rpb24oZXhwb3J0cykge1xuIFx0XHRpZih0eXBlb2YgU3ltYm9sICE9PSAndW5kZWZpbmVkJyAmJiBTeW1ib2wudG9TdHJpbmdUYWcpIHtcbiBcdFx0XHRPYmplY3QuZGVmaW5lUHJvcGVydHkoZXhwb3J0cywgU3ltYm9sLnRvU3RyaW5nVGFnLCB7IHZhbHVlOiAnTW9kdWxlJyB9KTtcbiBcdFx0fVxuIFx0XHRPYmplY3QuZGVmaW5lUHJvcGVydHkoZXhwb3J0cywgJ19fZXNNb2R1bGUnLCB7IHZhbHVlOiB0cnVlIH0pO1xuIFx0fTtcblxuIFx0Ly8gY3JlYXRlIGEgZmFrZSBuYW1lc3BhY2Ugb2JqZWN0XG4gXHQvLyBtb2RlICYgMTogdmFsdWUgaXMgYSBtb2R1bGUgaWQsIHJlcXVpcmUgaXRcbiBcdC8vIG1vZGUgJiAyOiBtZXJnZSBhbGwgcHJvcGVydGllcyBvZiB2YWx1ZSBpbnRvIHRoZSBuc1xuIFx0Ly8gbW9kZSAmIDQ6IHJldHVybiB2YWx1ZSB3aGVuIGFscmVhZHkgbnMgb2JqZWN0XG4gXHQvLyBtb2RlICYgOHwxOiBiZWhhdmUgbGlrZSByZXF1aXJlXG4gXHRfX3dlYnBhY2tfcmVxdWlyZV9fLnQgPSBmdW5jdGlvbih2YWx1ZSwgbW9kZSkge1xuIFx0XHRpZihtb2RlICYgMSkgdmFsdWUgPSBfX3dlYnBhY2tfcmVxdWlyZV9fKHZhbHVlKTtcbiBcdFx0aWYobW9kZSAmIDgpIHJldHVybiB2YWx1ZTtcbiBcdFx0aWYoKG1vZGUgJiA0KSAmJiB0eXBlb2YgdmFsdWUgPT09ICdvYmplY3QnICYmIHZhbHVlICYmIHZhbHVlLl9fZXNNb2R1bGUpIHJldHVybiB2YWx1ZTtcbiBcdFx0dmFyIG5zID0gT2JqZWN0LmNyZWF0ZShudWxsKTtcbiBcdFx0X193ZWJwYWNrX3JlcXVpcmVfXy5yKG5zKTtcbiBcdFx0T2JqZWN0LmRlZmluZVByb3BlcnR5KG5zLCAnZGVmYXVsdCcsIHsgZW51bWVyYWJsZTogdHJ1ZSwgdmFsdWU6IHZhbHVlIH0pO1xuIFx0XHRpZihtb2RlICYgMiAmJiB0eXBlb2YgdmFsdWUgIT0gJ3N0cmluZycpIGZvcih2YXIga2V5IGluIHZhbHVlKSBfX3dlYnBhY2tfcmVxdWlyZV9fLmQobnMsIGtleSwgZnVuY3Rpb24oa2V5KSB7IHJldHVybiB2YWx1ZVtrZXldOyB9LmJpbmQobnVsbCwga2V5KSk7XG4gXHRcdHJldHVybiBucztcbiBcdH07XG5cbiBcdC8vIGdldERlZmF1bHRFeHBvcnQgZnVuY3Rpb24gZm9yIGNvbXBhdGliaWxpdHkgd2l0aCBub24taGFybW9ueSBtb2R1bGVzXG4gXHRfX3dlYnBhY2tfcmVxdWlyZV9fLm4gPSBmdW5jdGlvbihtb2R1bGUpIHtcbiBcdFx0dmFyIGdldHRlciA9IG1vZHVsZSAmJiBtb2R1bGUuX19lc01vZHVsZSA/XG4gXHRcdFx0ZnVuY3Rpb24gZ2V0RGVmYXVsdCgpIHsgcmV0dXJuIG1vZHVsZVsnZGVmYXVsdCddOyB9IDpcbiBcdFx0XHRmdW5jdGlvbiBnZXRNb2R1bGVFeHBvcnRzKCkgeyByZXR1cm4gbW9kdWxlOyB9O1xuIFx0XHRfX3dlYnBhY2tfcmVxdWlyZV9fLmQoZ2V0dGVyLCAnYScsIGdldHRlcik7XG4gXHRcdHJldHVybiBnZXR0ZXI7XG4gXHR9O1xuXG4gXHQvLyBPYmplY3QucHJvdG90eXBlLmhhc093blByb3BlcnR5LmNhbGxcbiBcdF9fd2VicGFja19yZXF1aXJlX18ubyA9IGZ1bmN0aW9uKG9iamVjdCwgcHJvcGVydHkpIHsgcmV0dXJuIE9iamVjdC5wcm90b3R5cGUuaGFzT3duUHJvcGVydHkuY2FsbChvYmplY3QsIHByb3BlcnR5KTsgfTtcblxuIFx0Ly8gX193ZWJwYWNrX3B1YmxpY19wYXRoX19cbiBcdF9fd2VicGFja19yZXF1aXJlX18ucCA9IFwiL1wiO1xuXG5cbiBcdC8vIExvYWQgZW50cnkgbW9kdWxlIGFuZCByZXR1cm4gZXhwb3J0c1xuIFx0cmV0dXJuIF9fd2VicGFja19yZXF1aXJlX18oX193ZWJwYWNrX3JlcXVpcmVfXy5zID0gMSk7XG4iLCJmdW5jdGlvbiBfY2xhc3NDYWxsQ2hlY2soaW5zdGFuY2UsIENvbnN0cnVjdG9yKSB7XG4gIGlmICghKGluc3RhbmNlIGluc3RhbmNlb2YgQ29uc3RydWN0b3IpKSB7XG4gICAgdGhyb3cgbmV3IFR5cGVFcnJvcihcIkNhbm5vdCBjYWxsIGEgY2xhc3MgYXMgYSBmdW5jdGlvblwiKTtcbiAgfVxufVxuXG5tb2R1bGUuZXhwb3J0cyA9IF9jbGFzc0NhbGxDaGVjazsiLCJmdW5jdGlvbiBfZGVmaW5lUHJvcGVydGllcyh0YXJnZXQsIHByb3BzKSB7XG4gIGZvciAodmFyIGkgPSAwOyBpIDwgcHJvcHMubGVuZ3RoOyBpKyspIHtcbiAgICB2YXIgZGVzY3JpcHRvciA9IHByb3BzW2ldO1xuICAgIGRlc2NyaXB0b3IuZW51bWVyYWJsZSA9IGRlc2NyaXB0b3IuZW51bWVyYWJsZSB8fCBmYWxzZTtcbiAgICBkZXNjcmlwdG9yLmNvbmZpZ3VyYWJsZSA9IHRydWU7XG4gICAgaWYgKFwidmFsdWVcIiBpbiBkZXNjcmlwdG9yKSBkZXNjcmlwdG9yLndyaXRhYmxlID0gdHJ1ZTtcbiAgICBPYmplY3QuZGVmaW5lUHJvcGVydHkodGFyZ2V0LCBkZXNjcmlwdG9yLmtleSwgZGVzY3JpcHRvcik7XG4gIH1cbn1cblxuZnVuY3Rpb24gX2NyZWF0ZUNsYXNzKENvbnN0cnVjdG9yLCBwcm90b1Byb3BzLCBzdGF0aWNQcm9wcykge1xuICBpZiAocHJvdG9Qcm9wcykgX2RlZmluZVByb3BlcnRpZXMoQ29uc3RydWN0b3IucHJvdG90eXBlLCBwcm90b1Byb3BzKTtcbiAgaWYgKHN0YXRpY1Byb3BzKSBfZGVmaW5lUHJvcGVydGllcyhDb25zdHJ1Y3Rvciwgc3RhdGljUHJvcHMpO1xuICByZXR1cm4gQ29uc3RydWN0b3I7XG59XG5cbm1vZHVsZS5leHBvcnRzID0gX2NyZWF0ZUNsYXNzOyIsInJlcXVpcmUoJy4vc29rb2Jhbi9zdGFydCcpOyIsImltcG9ydCB7XHJcbiAgU2ltcGxlRXZlbnQsXHJcbiAgR2FtZUV2ZW50XHJcbn0gZnJvbSAnLi9HYW1lRXZlbnQnO1xyXG5cclxuY29uc3QgX2hpc3RvcnlNb3ZlbWVudCA9IFN5bWJvbCgpO1xyXG5jb25zdCBfbWF4TW92ZUNvdW50ID0gU3ltYm9sKCk7XHJcbmNvbnN0IF9pbmRleE1vdmUgPSBTeW1ib2woKTtcclxuY29uc3QgX2N1cnJlbnRNb3ZlQ291bnQgPSBTeW1ib2woKTtcclxuY29uc3QgX2ludGVydmFsID0gU3ltYm9sKCk7XHJcbmNvbnN0IF9pc1RpbWVSdW5uaW5nID0gU3ltYm9sKCk7XHJcbmNvbnN0IF9zdGFydFRpbWVyID0gU3ltYm9sKCk7XHJcbmNvbnN0IF9jb3VudGVyID0gU3ltYm9sKCk7XHJcbmNvbnN0IF91cGRhdGVUaW1lID0gU3ltYm9sKCk7XHJcbmNvbnN0IF90aW1lQ2hhbmdlRXZlbnQgPSBTeW1ib2woKTtcclxuY29uc3QgX2luZGV4TW92ZUNoYW5nZUV2ZW50ID0gU3ltYm9sKCk7XHJcblxyXG5leHBvcnQgY2xhc3MgR2FtZUNvbnRyb2wge1xyXG5cclxuICBjb25zdHJ1Y3RvcigpIHtcclxuICAgIHRoaXNbX2hpc3RvcnlNb3ZlbWVudF0gPSBbXTtcclxuICAgIHRoaXNbX21heE1vdmVDb3VudF0gPSAwO1xyXG4gICAgdGhpc1tfY3VycmVudE1vdmVDb3VudF0gPSAwO1xyXG4gICAgdGhpc1tfaW5kZXhNb3ZlXSA9IDA7XHJcbiAgICB0aGlzW19jb3VudGVyXSA9IDA7XHJcbiAgICB0aGlzW19pc1RpbWVSdW5uaW5nXSA9IGZhbHNlO1xyXG4gICAgLy8gUmVnaXN0ZXIgdGltZUNoYW5nZUV2ZW50XHJcbiAgICB0aGlzW190aW1lQ2hhbmdlRXZlbnRdID0gbmV3IFNpbXBsZUV2ZW50KCd0aW1lQ2hhbmdlRXZlbnQnKTtcclxuICAgIEdhbWVFdmVudC5ldmVudHNbJ3RpbWVDaGFuZ2VFdmVudCddID0gdGhpc1tfdGltZUNoYW5nZUV2ZW50XTtcclxuICAgIC8vIFJlZ2lzdGVyIGluZGV4TW92ZUNoYW5nZUV2ZW50XHJcbiAgICB0aGlzW19pbmRleE1vdmVDaGFuZ2VFdmVudF0gPSBuZXcgU2ltcGxlRXZlbnQoJ2luZGV4TW92ZUNoYW5nZUV2ZW50Jyk7XHJcbiAgICBHYW1lRXZlbnQuZXZlbnRzWydpbmRleE1vdmVDaGFuZ2VFdmVudCddID0gdGhpc1tfaW5kZXhNb3ZlQ2hhbmdlRXZlbnRdO1xyXG4gIH1cclxuXHJcbiAgW191cGRhdGVUaW1lXSgpIHtcclxuICAgIHRoaXNbX2NvdW50ZXJdICs9IDE7XHJcblxyXG4gICAgaWYgKHRoaXNbX2NvdW50ZXJdID49IDYwKSB7XHJcbiAgICAgIHRoaXNbX2NvdW50ZXJdID0gMDtcclxuICAgICAgdGhpc1tfbWludXRlc10gKz0gMTtcclxuICAgIH1cclxuICAgIHRoaXNbX3NlY29uZHNdID0gdGhpc1tfY291bnRlcl07XHJcbiAgfVxyXG5cclxuICBzdG9wVGltZXIoKSB7XHJcbiAgICB0aGlzW19pc1RpbWVSdW5uaW5nXSA9IGZhbHNlO1xyXG4gICAgY2xlYXJJbnRlcnZhbCh0aGlzW19pbnRlcnZhbF0pO1xyXG4gICAgR2FtZUV2ZW50LmRpc3BhdGNoRXZlbnQoJ3RpbWVDaGFuZ2VFdmVudCcpO1xyXG4gIH1cclxuXHJcbiAgW19zdGFydFRpbWVyXSgpIHtcclxuICAgIGlmICh0aGlzW19pc1RpbWVSdW5uaW5nXSA9PT0gdHJ1ZSkge1xyXG4gICAgICByZXR1cm47XHJcbiAgICB9XHJcbiAgICB0aGlzW19pc1RpbWVSdW5uaW5nXSA9IHRydWU7XHJcbiAgICB0aGlzW19pbnRlcnZhbF0gPSBzZXRJbnRlcnZhbCgoKSA9PiB7XHJcbiAgICAgIHRoaXNbX2NvdW50ZXJdICs9IDE7XHJcbiAgICAgIEdhbWVFdmVudC5kaXNwYXRjaEV2ZW50KCd0aW1lQ2hhbmdlRXZlbnQnKTtcclxuICAgIH0sIDEwMDApO1xyXG4gIH1cclxuXHJcbiAgLy8gZ2V0IHRoZSB0aW1lXHJcbiAgZ2V0IHRpbWVEdXJhdGlvbigpIHtcclxuICAgIGxldCBtaW51dGVzID0gTWF0aC5mbG9vcih0aGlzW19jb3VudGVyXSAvIDYwKTtcclxuICAgIGxldCBzZWNvbmRzID0gdGhpc1tfY291bnRlcl0gJSA2MDtcclxuICAgIGlmIChzZWNvbmRzIDwgMTApIHtcclxuICAgICAgc2Vjb25kcyA9IFwiMFwiICsgc2Vjb25kcztcclxuICAgIH1cclxuICAgIGlmIChtaW51dGVzIDwgMTApIHtcclxuICAgICAgbWludXRlcyA9IFwiMFwiICsgbWludXRlcztcclxuICAgIH1cclxuICAgIHJldHVybiBgJHttaW51dGVzfToke3NlY29uZHN9YDtcclxuICB9XHJcblxyXG4gIC8vIGdldCB0aGUgY3VycmVudCBpbmRleCBtb3ZlXHJcbiAgZ2V0IGluZGV4TW92ZSgpIHtcclxuICAgIHJldHVybiB0aGlzW19pbmRleE1vdmVdO1xyXG4gIH1cclxuICAvLyBzZXQgdGhlIGN1cnJlbnQgaW5kZXggbW92ZVxyXG4gIHNldCBpbmRleE1vdmUodmFsdWUpIHtcclxuICAgIHRoaXNbX2luZGV4TW92ZV0gPSB2YWx1ZTtcclxuICAgIC8vIHRyaWdnZXIgdGhlIGluZGV4TW92ZUNoYW5nZUV2ZW50XHJcbiAgICBHYW1lRXZlbnQuZGlzcGF0Y2hFdmVudCgnaW5kZXhNb3ZlQ2hhbmdlRXZlbnQnKTtcclxuICB9XHJcblxyXG4gIC8vIGdldCB0aGUgbWF4IG1vdmVzXHJcbiAgZ2V0IG1heE1vdmVDb3VudCgpIHtcclxuICAgIHJldHVybiB0aGlzW19oaXN0b3J5TW92ZW1lbnRdLmxlbmd0aDtcclxuICB9XHJcblxyXG4gIC8vIGdldCBhbGwgdGhlIG1vdmVzIGhpc3RvcnlcclxuICBnZXQgaGlzdG9yeSgpIHtcclxuICAgIHJldHVybiB0aGlzW19oaXN0b3J5TW92ZW1lbnRdO1xyXG4gIH1cclxuXHJcbiAgLy8gY2hlY2sgaWYgY2FuIG5hdmlnYXRlIHRocm93IHRoZSAobmV4dCB8fCBwcmV2aW91cykgbW92ZXNcclxuICBjYW5QbGF5KG1vdmVBbW91bnQpIHtcclxuICAgIGxldCBpbmRleCA9IG1vdmVBbW91bnQgKyB0aGlzLmluZGV4TW92ZTtcclxuXHJcbiAgICBpZiAoaW5kZXggPiAwICYmIGluZGV4IDwgdGhpcy5tYXhNb3ZlQ291bnQpIHtcclxuICAgICAgcmV0dXJuIHRydWU7XHJcbiAgICB9XHJcbiAgICByZXR1cm4gZmFsc2U7XHJcbiAgfVxyXG5cclxuICAvLyBzYXZlIHRoZSBtb3ZlXHJcbiAgc2F2ZU1vdmUobW92ZW1lbnQpIHtcclxuICAgIC8vIHN0YXJ0IHRoZSB0aW1lciBhZnRlciB0aGUgZmlyc3QgbW92ZVxyXG4gICAgdGhpc1tfc3RhcnRUaW1lcl0oKTtcclxuICAgIC8vIHJlbW92ZSBzdGVwcyBpZiB0aGVyZSBpcyBvbmNlIGFmdGVyIHRoZSBwbGF5ZXIgbW92ZWRcclxuICAgIHRoaXNbX2hpc3RvcnlNb3ZlbWVudF0gPSB0aGlzW19oaXN0b3J5TW92ZW1lbnRdLnNsaWNlKFxyXG4gICAgICAwLFxyXG4gICAgICB0aGlzW19pbmRleE1vdmVdXHJcbiAgICApO1xyXG5cclxuICAgIHRoaXNbX2hpc3RvcnlNb3ZlbWVudF0ucHVzaChtb3ZlbWVudCk7XHJcbiAgICB0aGlzLmluZGV4TW92ZSArPSAxO1xyXG4gIH1cclxuXHJcbiAgLy8gZ2V0IGEgbW92ZSBvciBtb3ZlcyBmcm9tIHRoZSBoaXN0b3J5XHJcbiAgZ2V0TW92ZSh2YWx1ZSkge1xyXG4gICAgbGV0IG1vdmVJbmRleCA9IHRoaXNbX2luZGV4TW92ZV0gKyB2YWx1ZTtcclxuICAgIGlmIChtb3ZlSW5kZXggPCAwKSB7XHJcbiAgICAgIG1vdmVJbmRleCA9IDA7XHJcbiAgICB9IGVsc2UgaWYgKG1vdmVJbmRleCA+IHRoaXMubWF4TW92ZUNvdW50KSB7XHJcbiAgICAgIG1vdmVJbmRleCA9IHRoaXMubWF4TW92ZUNvdW50O1xyXG4gICAgfVxyXG4gICAgbGV0IHN0YXJ0SW5kZXggPSBNYXRoLm1pbih0aGlzW19pbmRleE1vdmVdLCBtb3ZlSW5kZXgpO1xyXG4gICAgbGV0IGVuZEluZGV4ID0gTWF0aC5tYXgodGhpc1tfaW5kZXhNb3ZlXSwgbW92ZUluZGV4KTtcclxuICAgIHRoaXMuaW5kZXhNb3ZlID0gbW92ZUluZGV4O1xyXG4gICAgbGV0IGFycmF5ID0gdGhpc1tfaGlzdG9yeU1vdmVtZW50XS5zbGljZShcclxuICAgICAgc3RhcnRJbmRleCwgZW5kSW5kZXhcclxuICAgICk7XHJcblxyXG4gICAgcmV0dXJuIGFycmF5O1xyXG4gIH1cclxuXHJcbiAgLy8gcmVzZXRcclxuICByZXNldCgpIHtcclxuICAgIHRoaXNbX2hpc3RvcnlNb3ZlbWVudF0gPSBbXTtcclxuICAgIHRoaXNbX21heE1vdmVDb3VudF0gPSAwO1xyXG4gICAgdGhpc1tfY3VycmVudE1vdmVDb3VudF0gPSAwO1xyXG4gICAgdGhpcy5pbmRleE1vdmUgPSAwO1xyXG4gICAgdGhpc1tfY291bnRlcl0gPSAwO1xyXG4gICAgdGhpcy5zdG9wVGltZXIoKTtcclxuICB9XHJcbn0iLCJleHBvcnQgY2xhc3MgU2ltcGxlRXZlbnQge1xyXG4gIGNvbnN0cnVjdG9yKG5hbWUpIHtcclxuICAgIHRoaXMubmFtZSA9IG5hbWU7XHJcbiAgICB0aGlzLmhhbmRsZXJzID0gW107XHJcbiAgfVxyXG4gIHJlZ2lzdGVySGFuZGxlcihoYW5kbGVyKSB7XHJcbiAgICB0aGlzLmhhbmRsZXJzLnB1c2goaGFuZGxlcik7XHJcbiAgfVxyXG59XHJcblxyXG5sZXQgX2V2ZW50cyA9IHt9O1xyXG5leHBvcnQgY2xhc3MgR2FtZUV2ZW50IHtcclxuXHJcbiAgc3RhdGljIGdldCBldmVudHMoKSB7XHJcbiAgICByZXR1cm4gX2V2ZW50cztcclxuICB9XHJcblxyXG4gIHN0YXRpYyByZWdpc3RlckV2ZW50KGV2ZW50TmFtZSkge1xyXG4gICAgbGV0IEdhbWVFdmVudCA9IG5ldyBTaW1wbGVFdmVudChldmVudE5hbWUpO1xyXG4gICAgdGhpcy5ldmVudHNbZXZlbnROYW1lXSA9IEdhbWVFdmVudDtcclxuXHJcbiAgfVxyXG5cclxuICBzdGF0aWMgYWRkRXZlbnRMaXN0ZW5lcihldmVudE5hbWUsIGhhbmRsZXIpIHtcclxuICAgIHRoaXMuZXZlbnRzW2V2ZW50TmFtZV0ucmVnaXN0ZXJIYW5kbGVyKGhhbmRsZXIpO1xyXG4gIH1cclxuXHJcbiAgc3RhdGljIGRpc3BhdGNoRXZlbnQoZXZlbnROYW1lKSB7XHJcbiAgICB0aGlzLmV2ZW50c1tldmVudE5hbWVdLmhhbmRsZXJzLmZvckVhY2goZnVuY3Rpb24gKGNhbGxiYWNrKSB7XHJcbiAgICAgIGNhbGxiYWNrKCk7XHJcbiAgICB9KTtcclxuICB9XHJcbn0iLCJpbXBvcnQge1xyXG4gIHRpbGVNYXBzXHJcbn0gZnJvbSAnLi9Tb2tvYmFuQmFzZSc7XHJcbmltcG9ydCB7XHJcbiAgVGlsZUdyaWRcclxufSBmcm9tICcuL1RpbGVHcmlkJztcclxuaW1wb3J0IHtcclxuICBUaWxlR3JpZFRhYmxlXHJcbn0gZnJvbSAnLi9UaWxlR3JpZFRhYmxlJztcclxuaW1wb3J0IHtcclxuICBHYW1lQ29udHJvbFxyXG59IGZyb20gJy4vR2FtZUNvbnRyb2xzJztcclxuaW1wb3J0IHtcclxuICBHYW1lRXZlbnRcclxufSBmcm9tICcuL0dhbWVFdmVudCc7XHJcblxyXG5jb25zdCBfc2VsZWN0ZWRNYXAgPSBTeW1ib2woKTtcclxuY29uc3QgX3RpbGVHcmlkID0gU3ltYm9sKCk7XHJcbmNvbnN0IF9yZW5kZXJFbmdpbmUgPSBTeW1ib2woKTtcclxuY29uc3QgX3BsYXlNb3ZlcyA9IFN5bWJvbCgpO1xyXG5jb25zdCBfZ2FtZUNvbnRyb2wgPSBTeW1ib2woKTtcclxuXHJcbmV4cG9ydCBjbGFzcyBTb2tvYmFuIHtcclxuICBjb25zdHJ1Y3Rvcih3aWR0aCwgaGVpZ2h0KSB7XHJcbiAgICB0aGlzW19zZWxlY3RlZE1hcF0gPSB0aWxlTWFwc1swXTtcclxuICAgIHRoaXNbX3RpbGVHcmlkXSA9IG5ldyBUaWxlR3JpZCh0aGlzW19zZWxlY3RlZE1hcF0ubWFwR3JpZCwgd2lkdGgsIGhlaWdodCk7XHJcbiAgICB0aGlzW19nYW1lQ29udHJvbF0gPSBuZXcgR2FtZUNvbnRyb2woKTtcclxuICB9XHJcblxyXG4gIC8vIGFwcGx5IHRoZSBtb3ZlbWVudCBvbiB0aGUgbWFwXHJcbiAgLy8gY2hlY2sgZm9yIHdpbmluZ1xyXG4gIFtfcGxheU1vdmVzXShtb3Zlcykge1xyXG4gICAgbW92ZXMuZm9yRWFjaChtb3ZlID0+IHtcclxuICAgICAgdGhpcy50aWxlR3JpZC5hcHBseU1vdmVtZW50KG1vdmUpO1xyXG4gICAgICB0aGlzW19yZW5kZXJFbmdpbmVdLnVwZGF0ZVRpbGVzKG1vdmUpO1xyXG4gICAgfSk7XHJcbiAgICAvLyBjaGVjayBmb3Igd2luXHJcbiAgICBpZiAodGhpcy50aWxlR3JpZC5pc0dhbWVFbmQpIHtcclxuICAgICAgR2FtZUV2ZW50LmRpc3BhdGNoRXZlbnQoJ2dhbWVFbmRFdmVudCcpO1xyXG4gICAgICB0aGlzLmdhbWVDb250cm9sLnN0b3BUaW1lcigpO1xyXG4gICAgfVxyXG4gIH1cclxuXHJcbiAgLy8gbW92ZSB0aGUgcGxheWVyIGJhc2VkIG9uIGRpcmVjdGlvblxyXG4gIC8vIHNhdmUgdGhlIG1vdmVcclxuICBtb3ZlKHhEaXJlY3Rpb24sIHlEaXJlY3Rpb24pIHtcclxuICAgIGxldCBtb3ZlID0gdGhpcy50aWxlR3JpZC5idWlsZE1vdmVtZW50KHhEaXJlY3Rpb24sIHlEaXJlY3Rpb24pO1xyXG4gICAgaWYgKG1vdmUubGVuZ3RoID4gMCAmJiB0aGlzLnRpbGVHcmlkLmlzR2FtZUVuZCA9PT0gZmFsc2UpIHtcclxuICAgICAgdGhpcy5nYW1lQ29udHJvbC5zYXZlTW92ZShtb3ZlKTtcclxuICAgICAgdGhpc1tfcGxheU1vdmVzXShbbW92ZV0pO1xyXG4gICAgfVxyXG4gIH1cclxuXHJcbiAgZ2V0IGdhbWVDb250cm9sKCkge1xyXG4gICAgcmV0dXJuIHRoaXNbX2dhbWVDb250cm9sXTtcclxuICB9XHJcblxyXG4gIGdldCB0aWxlR3JpZCgpIHtcclxuICAgIHJldHVybiB0aGlzW190aWxlR3JpZF07XHJcbiAgfVxyXG4gIFxyXG4gIC8vICsxLCAtMSwgKzEwLCAtMTBcclxuICBwbGF5TW92ZSh2YWx1ZSkge1xyXG4gICAgbGV0IG1vdmVzID0gdGhpcy5nYW1lQ29udHJvbC5nZXRNb3ZlKHZhbHVlKTtcclxuXHJcbiAgICBpZiAodmFsdWUgPCAtMSkge1xyXG4gICAgICBtb3Zlcy5yZXZlcnNlKCk7XHJcbiAgICB9XHJcbiAgICB0aGlzW19wbGF5TW92ZXNdKG1vdmVzKTtcclxuICB9XHJcblxyXG4gIC8vIHJlc3RhcnQgdGhlIGdhbWVcclxuICByZXN0YXJ0KCkge1xyXG4gICAgbGV0IHRpbGVHcmlkRGltZW5zaW9uID0gdGhpc1tfdGlsZUdyaWRdLnRpbGVHcmlkRGltZW5zaW9uO1xyXG4gICAgdGhpc1tfdGlsZUdyaWRdID0gbmV3IFRpbGVHcmlkKHRoaXNbX3NlbGVjdGVkTWFwXS5tYXBHcmlkLCB0aWxlR3JpZERpbWVuc2lvbiwgdGlsZUdyaWREaW1lbnNpb24pO1xyXG4gICAgdGhpcy5nYW1lQ29udHJvbC5yZXNldCgpO1xyXG4gIH1cclxuXHJcbiAgLy8gc2VsZWN0IG5ldyB0aWxlTWFwXHJcbiAgc2VsZWN0TWFwKHNlbGVjdGVkTWFwID0gMCkge1xyXG4gICAgdGhpc1tfc2VsZWN0ZWRNYXBdID0gdGlsZU1hcHNbc2VsZWN0ZWRNYXBdO1xyXG4gICAgdGhpcy5yZXN0YXJ0KCk7XHJcbiAgfVxyXG5cclxuICAvLyBjaGFuZ2UgdGhlIHJlbmRlciBlbmdpbmVcclxuICBzZXRSZW5kZXJFbmdpbmUocmVuZGVyRW5naW5lKSB7XHJcbiAgICBzd2l0Y2ggKHJlbmRlckVuZ2luZSkge1xyXG4gICAgICBjYXNlICdkaXZzJzpcclxuICAgICAgICAvLyBjaGFuZ2UgcmVuZGVyIHRvIGRpdnNcclxuICAgICAgICBicmVhaztcclxuICAgICAgZGVmYXVsdDpcclxuICAgICAgICAvLyBzZXQgZGVmYXVsdCB0byB0YWJsZVxyXG4gICAgICAgIHRoaXNbX3JlbmRlckVuZ2luZV0gPSBuZXcgVGlsZUdyaWRUYWJsZSh0aGlzLnRpbGVHcmlkKTtcclxuICAgICAgICBicmVhaztcclxuICAgIH1cclxuICB9XHJcblxyXG4gIC8vIGRyYXdpbmcgdGhlIHRpbGVNYXBcclxuICBjcmVhdGVUaWxlTWFwKCkge1xyXG4gICAgcmV0dXJuIHRoaXNbX3JlbmRlckVuZ2luZV0uY3JlYXRlVGlsZU1hcCgpO1xyXG4gIH1cclxufSIsIlxyXG4vKiAgIFRoaXMgaXMgdGhlIGJhc2UgZmlsZSBmb3IgdGhlIFNva29iYW4gYXNzaWdubWVudCAtIGluY2x1ZGUgdGhpcyBvbmUgaW4geW91ciBIVE1MIHBhZ2UsIGJlZm9yZSB5b3UgYWRkIHRoZSBtYWluIHNjcmlwdCBmaWxlKi9cclxuXHJcbi8qICAgRW51bSBvZiBDU1MgQ2xhc3NlcyBmb3IgdGhlIHN0YXRpYyBlbGVtZW50cyAgICovXHJcbnZhciBUaWxlcyA9IHtcclxuICBXYWxsOiBcInRpbGUtd2FsbFwiLFxyXG4gIFNwYWNlOiBcInRpbGUtc3BhY2VcIixcclxuICBHb2FsOiBcInRpbGUtZ29hbFwiXHJcbn07XHJcblxyXG4vKiAgIEVudW0gb2YgQ1NTIENsYXNzZXMgZm9yIHRoZSBtb3ZpbmcgZWxlbWVudHMgICAqL1xyXG52YXIgRW50aXRpZXMgPSB7XHJcbiAgQ2hhcmFjdGVyOiBcImVudGl0eS1wbGF5ZXJcIixcclxuICBCbG9jazogXCJlbnRpdHktYmxvY2tcIixcclxuICBCbG9ja0RvbmU6IFwiZW50aXR5LWJsb2NrLWdvYWxcIlxyXG59O1xyXG5cclxuLyogIExlZ2VuZFxyXG4gIFcgPSBXYWxsXHJcbiAgQiA9IE1vdmFibGUgYmxvY2tcclxuICBQID0gUGxheWVyIHN0YXJ0aW5nIHBvc2l0aW9uXHJcbiAgRyA9IEdvYWwgYXJlYSBmb3IgdGhlIGJsb2Nrc1xyXG4qL1xyXG5leHBvcnQgdmFyIHRpbGVNYXBzID0gW1xyXG4gIHtcclxuICAgIG5hbWU6IFwiT3JnaW5hbFwiLFxyXG4gICAgbWFwR3JpZDogW1xyXG4gICAgW1snICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddXSxcclxuICAgIFtbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXV0sXHJcbiAgICBbWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ11dLFxyXG4gICAgW1snICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJ1cnXSwgWydXJ10sIFsnVyddLCBbJ1cnXSwgWydXJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddXSxcclxuICAgIFtbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWydXJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnVyddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXV0sXHJcbiAgICBbWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnVyddLCBbJ0InXSwgWycgJ10sIFsnICddLCBbJ1cnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ11dLFxyXG4gICAgW1snICddLCBbJyAnXSwgWydXJ10sIFsnVyddLCBbJ1cnXSwgWycgJ10sIFsnICddLCBbJ0InXSwgWydXJ10sIFsnVyddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddXSxcclxuICAgIFtbJyAnXSwgWycgJ10sIFsnVyddLCBbJyAnXSwgWycgJ10sIFsnQiddLCBbJyAnXSwgWydCJ10sIFsnICddLCBbJ1cnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXV0sXHJcbiAgICBbWydXJ10sIFsnVyddLCBbJ1cnXSwgWycgJ10sIFsnVyddLCBbJyAnXSwgWydXJ10sIFsnVyddLCBbJyAnXSwgWydXJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnVyddLCBbJ1cnXSwgWydXJ10sIFsnVyddLCBbJ1cnXSwgWydXJ11dLFxyXG4gICAgW1snVyddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJ1cnXSwgWycgJ10sIFsnVyddLCBbJ1cnXSwgWycgJ10sIFsnVyddLCBbJ1cnXSwgWydXJ10sIFsnVyddLCBbJ1cnXSwgWycgJ10sIFsnICddLCBbJ0cnXSwgWydHJ10sIFsnVyddXSxcclxuICAgIFtbJ1cnXSwgWycgJ10sIFsnQiddLCBbJyAnXSwgWycgJ10sIFsnQiddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnUCddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWydHJ10sIFsnRyddLCBbJ1cnXV0sXHJcbiAgICBbWydXJ10sIFsnVyddLCBbJ1cnXSwgWydXJ10sIFsnVyddLCBbJyAnXSwgWydXJ10sIFsnVyddLCBbJ1cnXSwgWycgJ10sIFsnVyddLCBbJyAnXSwgWydXJ10sIFsnVyddLCBbJyAnXSwgWycgJ10sIFsnRyddLCBbJ0cnXSwgWydXJ11dLFxyXG4gICAgW1snICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJ1cnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJ1cnXSwgWydXJ10sIFsnVyddLCBbJ1cnXSwgWydXJ10sIFsnVyddLCBbJ1cnXSwgWydXJ10sIFsnVyddXSxcclxuICAgIFtbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWydXJ10sIFsnVyddLCBbJ1cnXSwgWydXJ10sIFsnVyddLCBbJ1cnXSwgWydXJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXV0sXHJcbiAgICBbWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ11dLFxyXG4gICAgW1snICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddXVxyXG4gICAgXVxyXG4gIH0sXHJcbiAge1xyXG4gICAgbmFtZTogXCJUcnkgSXRcIixcclxuICAgIG1hcEdyaWQ6IFtcclxuICAgIFtbJ1cnXSwgWydXJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddXSxcclxuICAgIFtbJ1cnXSwgWycgJ10sIFsnICddLCBbJ1cnXSwgWydXJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddXSxcclxuICAgIFtbJyAnXSwgWydCJ10sIFsnICddLCBbJ0cnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddXSxcclxuICAgIFtbJyAnXSwgWycgJ10sIFsnICddLCBbJ0cnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddXSxcclxuICAgIFtbJ1cnXSwgWycgJ10sIFsnUCddLCBbJ0cnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddXSxcclxuICAgIFtbJ1cnXSwgWycgJ10sIFsnVyddLCBbJ1cnXSwgWydXJ10sIFsnICddLCBbJyAnXSwgWydCJ10sIFsnICddXSxcclxuICAgIFtbJyAnXSwgWydCJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddXSxcclxuICAgIFtbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddLCBbJyAnXSwgWycgJ10sIFsnICddXVxyXG4gICAgXVxyXG4gIH0sXHJcbiAge1xyXG4gICAgbmFtZTogXCJJcyBpdCBpbXBvc2libGUhXCIsXHJcbiAgICBtYXBHcmlkOiBbXHJcbiAgICAgIFtbJyAnXSxbJ1AnXSxbJyAnXSxbJyAnXSwgWycgJ11dLFxyXG4gICAgICBbWycgJ10sWycgJ10sWycgJ10sWydCJ10sIFsnICddXSxcclxuICAgICAgW1snICddLFsnICddLFsnICddLFsnICddLCBbJyAnXV0sXHJcbiAgICAgIFtbJyAnXSxbJ0InXSxbJyAnXSxbJyAnXSwgWycgJ11dLFxyXG4gICAgICBbWydHJ10sWycgJ10sWydHJ10sWycgJ10sIFsnICddXVxyXG4gICAgXVxyXG4gIH0sXHJcbl07XHJcblxyXG4iLCJjb25zdCBfdGlsZUltYWdlID0gU3ltYm9sKCk7XHJcbmNvbnN0IF9ob3N0SW1hZ2UgPSBTeW1ib2woKTtcclxuY29uc3QgX2luaXRpYWx6ZVRpbGUgPSBTeW1ib2woKTtcclxuY29uc3QgX2hvc3RUeXBlID0gU3ltYm9sKCk7XHJcbmNvbnN0IF90eXBlID0gU3ltYm9sKCk7XHJcbmNvbnN0IF91cGRhdGVUaWxlSW1hZ2UgPSBTeW1ib2woKTtcclxuZXhwb3J0IGNsYXNzIFRpbGUge1xyXG5cclxuICBjb25zdHJ1Y3Rvcih0eXBlLCByb3csIGNvbHVtbikge1xyXG4gICAgdGhpcy5yb3cgPSByb3c7XHJcbiAgICB0aGlzLmNvbHVtbiA9IGNvbHVtbjtcclxuICAgIHRoaXNbX2hvc3RJbWFnZV0gPSAnICc7XHJcbiAgICB0aGlzW19pbml0aWFsemVUaWxlXSh0eXBlKTtcclxuICB9XHJcblxyXG4gIC8vIHRoZSB0eXBlIG9mIHRoZSB0aWxlIG5ldmVyIGdvbm5hIGNoYW5nZVxyXG4gIGdldCB0eXBlKCkge1xyXG4gICAgcmV0dXJuIHRoaXNbX3R5cGVdO1xyXG4gIH1cclxuXHJcbiAgLy8gdGhlIGhvc3RUeXBlIGlzIHZhbHVlKCdQJyB8ICdCJyB8ICcgJykgdGhhdCB0aGUgdGlsZSBpcyBob2xkaW5nXHJcbiAgc2V0IGhvc3RUeXBlKGhvc3RUeXBlKSB7XHJcbiAgICB0aGlzW19ob3N0VHlwZV0gPSBob3N0VHlwZTtcclxuICAgIC8vIGFmdGVyIHRoZSBob3N0VHlwZSBjaGFuZ2UgdXBkYXRlIHRoZSB0aWxlIGltYWdlXHJcbiAgICB0aGlzW191cGRhdGVUaWxlSW1hZ2VdKCk7XHJcbiAgfVxyXG5cclxuICAvLyBnZXQgdGhlIGhvc3RUeXBlIG9mIHRoZSB0aWxlXHJcbiAgZ2V0IGhvc3RUeXBlKCkge1xyXG4gICAgcmV0dXJuIHRoaXNbX2hvc3RUeXBlXTtcclxuICB9XHJcblxyXG4gIC8vIGdldCB0aGUgaW1hZ2Ugb2YgaG9zdFR5cGUgYmVjb3VzZSB0aGF0cyB3aGF0IGl0IHdpbGwgYmUgcmVuZGVyXHJcbiAgZ2V0IHRpbGVJbWFnZSgpIHtcclxuICAgIHJldHVybiB0aGlzW190aWxlSW1hZ2VdO1xyXG4gIH1cclxuXHJcbiAgLy8gY2hlY2sgaWYgdGhpcyBjZWxsIGNhbiBjb250YWluIGEgaG9zdFR5cGVcclxuICBnZXQgY2FuQ29udGFpbkhvc3QoKSB7XHJcbiAgICByZXR1cm4gdGhpc1tfaG9zdFR5cGVdID09PSAnICc7XHJcbiAgfVxyXG5cclxuICBbX2luaXRpYWx6ZVRpbGVdKHR5cGUpIHtcclxuICAgIGlmICh0eXBlID09PSAnRycpIHtcclxuICAgICAgdGhpc1tfdHlwZV0gPSAnRyc7XHJcbiAgICAgIHRoaXMuaG9zdFR5cGUgPSAnICc7XHJcbiAgICB9IGVsc2UgaWYgKHR5cGUgPT09ICdXJykge1xyXG4gICAgICB0aGlzW190eXBlXSA9ICdXJztcclxuICAgICAgdGhpcy5ob3N0VHlwZSA9ICdXJztcclxuICAgIH0gZWxzZSBpZiAodHlwZSA9PT0gJ0InKSB7XHJcbiAgICAgIHRoaXNbX3R5cGVdID0gJyAnO1xyXG4gICAgICB0aGlzLmhvc3RUeXBlID0gJ0InO1xyXG4gICAgfSBlbHNlIGlmICh0eXBlID09PSAnUCcpIHtcclxuICAgICAgdGhpc1tfdHlwZV0gPSAnICc7XHJcbiAgICAgIHRoaXMuaG9zdFR5cGUgPSAnUCc7XHJcbiAgICB9IGVsc2Uge1xyXG4gICAgICB0aGlzW190eXBlXSA9ICcgJztcclxuICAgICAgdGhpcy5ob3N0VHlwZSA9ICcgJztcclxuICAgIH1cclxuICB9XHJcblxyXG4gIFtfdXBkYXRlVGlsZUltYWdlXSgpIHtcclxuICAgIGxldCB0eXBlID0gdGhpc1tfaG9zdFR5cGVdICE9PSAnICcgPyB0aGlzW19ob3N0VHlwZV0gOiB0aGlzW190eXBlXTtcclxuICAgIHN3aXRjaCAodHlwZSkge1xyXG4gICAgICBjYXNlICdXJzpcclxuICAgICAgICB0aGlzW190aWxlSW1hZ2VdID0gJ3dhbGwucG5nJztcclxuICAgICAgICBicmVhaztcclxuICAgICAgY2FzZSAnQic6XHJcbiAgICAgICAgdGhpc1tfdGlsZUltYWdlXSA9IHRoaXNbX3R5cGVdID09PSAnRycgPyBcImNvcnJlY3RfYm94LnBuZ1wiIDogXCJib3gucG5nXCI7XHJcbiAgICAgICAgYnJlYWs7XHJcbiAgICAgIGNhc2UgJ1AnOlxyXG4gICAgICAgIHRoaXNbX3RpbGVJbWFnZV0gPSAncGxheWVyLnBuZyc7XHJcbiAgICAgICAgYnJlYWs7XHJcbiAgICAgIGNhc2UgJ0cnOlxyXG4gICAgICAgIHRoaXNbX3RpbGVJbWFnZV0gPSAnZ29hbC5wbmcnO1xyXG4gICAgICAgIGJyZWFrO1xyXG4gICAgICBkZWZhdWx0OlxyXG4gICAgICAgIHRoaXNbX3RpbGVJbWFnZV0gPSAnZW1wdHlUaWxlLnBuZyc7XHJcbiAgICAgICAgYnJlYWs7XHJcbiAgICB9XHJcbiAgfVxyXG59IiwiaW1wb3J0IHtcclxuICBUaWxlXHJcbn0gZnJvbSAnLi9UaWxlJztcclxuaW1wb3J0IHtcclxuICBTaW1wbGVFdmVudCxcclxuICBHYW1lRXZlbnRcclxufSBmcm9tICcuL0dhbWVFdmVudCc7XHJcbmNvbnN0IF90aWxlR3JpZCA9IFN5bWJvbCgpO1xyXG5jb25zdCBfY3JlYXRlVGlsZU1hcCA9IFN5bWJvbCgpO1xyXG5jb25zdCBfcm93cyA9IFN5bWJvbCgpO1xyXG5jb25zdCBfY29sdW1ucyA9IFN5bWJvbCgpO1xyXG5jb25zdCBfdGlsZUdyaWREaW1lbnNpb24gPSBTeW1ib2woKTtcclxuY29uc3QgX3RpbGVEaW1lbnNpb25JblByZWNlbnQgPSBTeW1ib2woKTtcclxuY29uc3QgX2NhbGN1bGF0ZVRpbGVEaW1lbnNpb25JblByZWNlbnQgPSBTeW1ib2woKTtcclxuY29uc3QgX3BsYXllclggPSBTeW1ib2woKTtcclxuY29uc3QgX3BsYXllclkgPSBTeW1ib2woKTtcclxuY29uc3QgX2dvYWxUaWxlcyA9IFN5bWJvbCgpO1xyXG5jb25zdCBfZ2FtZUVuZEV2ZW50ID0gU3ltYm9sKCk7XHJcbmV4cG9ydCBjbGFzcyBUaWxlR3JpZCB7XHJcblxyXG4gIGNvbnN0cnVjdG9yKHRpbGVHcmlkLCB0aWxlR3JpZFdpZHRoLCB0aWxlR3JpZEhlaWdodCA9IDApIHtcclxuICAgIHRoaXNbX3RpbGVHcmlkXSA9IHRoaXNbX2NyZWF0ZVRpbGVNYXBdKHRpbGVHcmlkKTtcclxuICAgIHRoaXNbX3Jvd3NdID0gdGhpc1tfdGlsZUdyaWRdLmxlbmd0aDtcclxuICAgIHRoaXNbX2NvbHVtbnNdID0gdGhpc1tfdGlsZUdyaWRdWzBdLmxlbmd0aDtcclxuICAgIHRoaXNbX3RpbGVHcmlkRGltZW5zaW9uXSA9IE1hdGgubWluKHRpbGVHcmlkV2lkdGgsIHRpbGVHcmlkSGVpZ2h0KTtcclxuICAgIHRoaXNbX3RpbGVEaW1lbnNpb25JblByZWNlbnRdID0gdGhpc1tfY2FsY3VsYXRlVGlsZURpbWVuc2lvbkluUHJlY2VudF0oKTtcclxuICAgIHRoaXNbX2dhbWVFbmRFdmVudF0gPSBuZXcgU2ltcGxlRXZlbnQoJ2dhbWVFbmRFdmVudCcpO1xyXG4gICAgR2FtZUV2ZW50LmV2ZW50c1snZ2FtZUVuZEV2ZW50J10gPSB0aGlzW19nYW1lRW5kRXZlbnRdO1xyXG4gIH1cclxuXHJcbiAgLy8gZmlsbCBpbiB0aGUgZ3JpZCB3aXRoIHRpbGVzIGFuZCBzZXQgdGhlIHN0YXJ0ZXIgcG9pbnRcclxuICBbX2NyZWF0ZVRpbGVNYXBdKHRpbGVHcmlkKSB7XHJcbiAgICBsZXQgdGlsZU1hcCA9IFtdO1xyXG4gICAgdGhpc1tfZ29hbFRpbGVzXSA9IFtdO1xyXG4gICAgZm9yIChsZXQgaSA9IDA7IGkgPCB0aWxlR3JpZC5sZW5ndGg7IGkrKykge1xyXG4gICAgICBsZXQgY29sdW1ucyA9IFtdO1xyXG4gICAgICBmb3IgKGxldCBqID0gMDsgaiA8IHRpbGVHcmlkW2ldLmxlbmd0aDsgaisrKSB7XHJcbiAgICAgICAgbGV0IHRpbGUgPSBuZXcgVGlsZSh0aWxlR3JpZFtpXVtqXVswXSwgaSwgaik7XHJcbiAgICAgICAgaWYgKHRpbGVHcmlkW2ldW2pdWzBdID09PSAnUCcpIHtcclxuICAgICAgICAgIHRoaXNbX3BsYXllclhdID0gaTtcclxuICAgICAgICAgIHRoaXNbX3BsYXllclldID0gajtcclxuICAgICAgICB9IGVsc2UgaWYgKHRpbGVHcmlkW2ldW2pdWzBdID09PSAnRycpIHtcclxuICAgICAgICAgIHRoaXNbX2dvYWxUaWxlc10ucHVzaCh0aWxlKTtcclxuICAgICAgICB9XHJcbiAgICAgICAgY29sdW1ucy5wdXNoKHRpbGUpO1xyXG4gICAgICB9XHJcbiAgICAgIHRpbGVNYXAucHVzaChjb2x1bW5zKTtcclxuICAgIH1cclxuICAgIHJldHVybiB0aWxlTWFwO1xyXG4gIH1cclxuXHJcbiAgLy8gY2FsY3VsYXRlIGhvdyBtdXNoIHNwYWNlIGVhY2ggdGlsZSB3aWxsIHRha2UgYmFzZWQgb24gdGhlIGdyaWQgKGhlaWdodCB8fCB3aWR0aClcclxuICBbX2NhbGN1bGF0ZVRpbGVEaW1lbnNpb25JblByZWNlbnRdKCkge1xyXG4gICAgbGV0IHRpbGVNYXBSaWIgPSBNYXRoLm1heCh0aGlzW19yb3dzXSwgdGhpc1tfY29sdW1uc10pO1xyXG4gICAgbGV0IHRpbGVEaW1lbnNpb24gPSB0aGlzW190aWxlR3JpZERpbWVuc2lvbl0gLyB0aWxlTWFwUmliO1xyXG4gICAgbGV0IHRpbGVNYXBEaW1lbnNpb25JblByZWNlbnQgPSB0aWxlRGltZW5zaW9uIC8gdGhpc1tfdGlsZUdyaWREaW1lbnNpb25dICogMTAwO1xyXG4gICAgcmV0dXJuIHRpbGVNYXBEaW1lbnNpb25JblByZWNlbnQ7XHJcbiAgfVxyXG5cclxuICAvLyBnZXQgdGhlIGdyaWQgdGhhdCBjb250YWluIGFsbCB0aGUgdGlsZXNcclxuICBnZXQgdGlsZXMoKSB7XHJcbiAgICByZXR1cm4gdGhpc1tfdGlsZUdyaWRdO1xyXG4gIH1cclxuXHJcbiAgLy8gZ2V0IHRoZSBncmlkIGRpbWVuc2lvblxyXG4gIGdldCB0aWxlR3JpZERpbWVuc2lvbigpIHtcclxuICAgIHJldHVybiB0aGlzW190aWxlR3JpZERpbWVuc2lvbl07XHJcbiAgfVxyXG5cclxuICAvLyBnZXQgdGhlIHRpbGUgZGltZW5zaW9uXHJcbiAgZ2V0IHRpbGVEaW1lbnNpb25JblByZWNlbnQoKSB7XHJcbiAgICByZXR1cm4gdGhpc1tfdGlsZURpbWVuc2lvbkluUHJlY2VudF07XHJcbiAgfVxyXG5cclxuICAvLyBDaGVjayBpZiB0aGUgZ2FtZSBlbmRlZFxyXG4gIC8vIFJldHVybjogYm9vbGVhblxyXG4gIGdldCBpc0dhbWVFbmQoKSB7XHJcbiAgICByZXR1cm4gdGhpc1tfZ29hbFRpbGVzXS5maWx0ZXIodCA9PiB0Lmhvc3RUeXBlICE9PSAnQicpLmxlbmd0aCA9PT0gMDtcclxuICB9XHJcblxyXG4gIC8vIHVwZGF0ZSB0aGUgZGVtaW5zaW9uIG9mIHRoZSBtYXBcclxuICB1cGRhdGVUaWxlR3JpZERpbWVuc2lvbihoZWlnaHQsIHdpZHRoKSB7XHJcbiAgICAvLyB0byBtYWludGFpbiB0aGUgYXNwZWN0IHJhdGlvIG9mIHRoZSBtYXAgd2UgdGFrZSB0aGUgc21hbGxlc3RcclxuICAgIHRoaXNbX3RpbGVHcmlkRGltZW5zaW9uXSA9IE1hdGgubWluKGhlaWdodCwgd2lkdGgpO1xyXG4gIH1cclxuXHJcbiAgLy8gcmV0dXJuIGxpc3Qgb2YgdGlsZXMoXCJtb3ZlbWVudHNcIikgZnJvbSB0aGUgc3RhcnQgcG9pbnQgXCJwbGF5ZXJcIiB0byB0aGUgZGlyZWN0aW9uLlxyXG4gIC8vIGRpcmVjdGlvbiBjb3VsZCBiZSAndG9wLCByaWdodCwgYm90dG9tLCBsZWZ0Jy5cclxuICAvLyBpZiByZXR1cm4gW10gZGlyZWN0aW9uIGlzIGJsb2NrZWQgb3Igb3V0IG9mIHJhbmdlXHJcbiAgYnVpbGRNb3ZlbWVudCh4RGlyZWN0aW9uLCB5RGlyZWN0aW9uLCBzdGFydFggPSB0aGlzW19wbGF5ZXJYXSwgc3RhcnRZID0gdGhpc1tfcGxheWVyWV0sIHByZXZpb3VzTW92ZW1lbnQgPSBbXSkge1xyXG4gICAgbGV0IHhUYXJnZXQgPSBzdGFydFggKyB4RGlyZWN0aW9uO1xyXG4gICAgbGV0IHlUYXJnZXQgPSBzdGFydFkgKyB5RGlyZWN0aW9uO1xyXG4gICAgLy8gQ2hlY2sgaWYgdGhlIHRhcmdldCBsb2NhdGlvbiBpcyBpbnNpZGUgdGhlIGdyaWRcclxuICAgIGlmICgoeFRhcmdldCA8IDAgfHwgeFRhcmdldCA+PSB0aGlzW190aWxlR3JpZF0ubGVuZ3RoKSB8fFxyXG4gICAgICAoeVRhcmdldCA8IDAgfHwgeVRhcmdldCA+PSB0aGlzW190aWxlR3JpZF1beFRhcmdldF0ubGVuZ3RoKSkge1xyXG4gICAgICByZXR1cm4gW107XHJcbiAgICB9XHJcbiAgICBsZXQgdGlsZSA9IHRoaXNbX3RpbGVHcmlkXVtzdGFydFhdW3N0YXJ0WV07XHJcbiAgICBsZXQgbmV4dFRpbGUgPSB0aGlzW190aWxlR3JpZF1beFRhcmdldF1beVRhcmdldF07XHJcbiAgICAvLyBpZiB0YXJnZXQgaXMgd2FsbCBkb24ndCBtb3ZlXHJcbiAgICBpZiAobmV4dFRpbGUudHlwZSA9PT0gJ1cnKSByZXR1cm4gW107XHJcbiAgICAvLyB3aGVuIHdlIGhhdmUgdHdvIGJveGVzXHJcbiAgICBpZiAodGlsZS5ob3N0VHlwZSA9PT0gJ0InICYmIG5leHRUaWxlLmhvc3RUeXBlID09PSAnQicpIHJldHVybiBbXTtcclxuICAgIC8vIGlmIHRoZSB0YXJnZXQgaXMgZW1wdHkgYW5kIGRvZXNuJ3QgY29udGFpbiBhIHRpbGVcclxuICAgIGVsc2UgaWYgKG5leHRUaWxlLnR5cGUgPT09ICcgJyAmJiBuZXh0VGlsZS5jYW5Db250YWluSG9zdCA9PT0gdHJ1ZSkge1xyXG4gICAgICBwcmV2aW91c01vdmVtZW50LnB1c2godGlsZSk7XHJcbiAgICAgIHByZXZpb3VzTW92ZW1lbnQucHVzaChuZXh0VGlsZSk7XHJcbiAgICAgIHJldHVybiBwcmV2aW91c01vdmVtZW50O1xyXG4gICAgfVxyXG4gICAgLy8gaWYgdGhlIHRhcmdldCBpcyBjb3JyZWN0IGFuZCBkb2Vzbid0IGNvbnRhaW4gYSB0aWxlXHJcbiAgICBlbHNlIGlmIChuZXh0VGlsZS50eXBlID09PSAnRycgJiYgbmV4dFRpbGUuY2FuQ29udGFpbkhvc3QgPT09IHRydWUpIHtcclxuICAgICAgcHJldmlvdXNNb3ZlbWVudC5wdXNoKHRpbGUpO1xyXG4gICAgICBwcmV2aW91c01vdmVtZW50LnB1c2gobmV4dFRpbGUpO1xyXG4gICAgICByZXR1cm4gcHJldmlvdXNNb3ZlbWVudDtcclxuICAgIH1cclxuICAgIC8vIHRhcmdldCBpcyBjcmF0ZSBjaGVjayBpZiB0aGUgY3JhdGUgY2FuIG1vdmVcclxuICAgIGVsc2Uge1xyXG4gICAgICBwcmV2aW91c01vdmVtZW50LnB1c2godGlsZSk7XHJcbiAgICAgIHJldHVybiB0aGlzLmJ1aWxkTW92ZW1lbnQoeERpcmVjdGlvbiwgeURpcmVjdGlvbiwgeFRhcmdldCwgeVRhcmdldCwgcHJldmlvdXNNb3ZlbWVudCk7XHJcbiAgICB9XHJcbiAgfVxyXG5cclxuICAvLyB1cGRhdGUgdGhlIHRpbGVzIGJhc2VkIG9uIGxpc3Qgb2YgbW92ZW1lbnRcclxuICAvLyBhcmdzOlxyXG4gIC8vICBtb3ZlbWVudDogbGlzdCBvZiB0aWxlcyB0aGF0IG5lZWQgdG8gYmUgY2hhbmdlIGFmdGVyIHRoZSBwbGF5ZXIgbW92ZWRcclxuICBhcHBseU1vdmVtZW50KG1vdmVtZW50KSB7XHJcbiAgICAvLyB3aGVuIHdlIHBsYXkgdGhlIG1vdmUgYmFja3dvcmRcclxuICAgIC8vIGJlY291c2UgdGhlIG1vdmUgc3RhcnQgZnJvbSBsZWZ0IHRvIHJpZ2h0XHJcbiAgICBpZiAobW92ZW1lbnRbMF0uaG9zdFR5cGUgIT09ICcgJykge1xyXG4gICAgICBtb3ZlbWVudC5yZXZlcnNlKCk7XHJcbiAgICB9XHJcbiAgICAvLyBsb29wIHRocm93IHRoZSBtb3ZlcyBhbmQgc2hpZnQgdGhlbWUgdG93b3JkIHRoZSBlbXB0eSB0aWxlXHJcbiAgICBmb3IgKGxldCBpID0gMDsgaSA8IG1vdmVtZW50Lmxlbmd0aCAtIDE7IGkrKykge1xyXG4gICAgICBsZXQgdGlsZSA9IG1vdmVtZW50W2ldO1xyXG4gICAgICBsZXQgdGFyZ2V0VGlsZSA9IG1vdmVtZW50W2kgKyAxXTtcclxuICAgICAgbGV0IHRpbGVIb3N0VHlwZUNvcHkgPSB0YXJnZXRUaWxlLmhvc3RUeXBlO1xyXG5cclxuICAgICAgLy8gU3dpdGNoIHRoZSB0d28gdGlsZXMgZnJvbSB0aGUgbGVmdCB0byByaWdodFxyXG4gICAgICB0YXJnZXRUaWxlLmhvc3RUeXBlID0gdGlsZS5ob3N0VHlwZTtcclxuICAgICAgdGlsZS5ob3N0VHlwZSA9IHRpbGVIb3N0VHlwZUNvcHk7XHJcbiAgICB9XHJcbiAgICAvLyB1cGRhdGUgdGhlIHN0YXJ0ZXIgcG9pbnQgXCJwbGF5ZXJcIlxyXG4gICAgLy8gY2FsY3VsYXRlIHRoZSBkaXJlY3Rpb24gYWZ0ZXIgdGhlIHN0YXJ0ZXIgcG9pbnQgY2hhbmdlZFxyXG4gICAgbGV0IHBsYXllclRpbGUgPSBtb3ZlbWVudC5maWx0ZXIodGlsZSA9PiB0aWxlLmhvc3RUeXBlID09PSAnUCcpWzBdO1xyXG4gICAgdGhpc1tfcGxheWVyWF0gPSBwbGF5ZXJUaWxlLnJvdztcclxuICAgIHRoaXNbX3BsYXllclldID0gcGxheWVyVGlsZS5jb2x1bW47XHJcbiAgfVxyXG59IiwiaW1wb3J0IHtcclxuICBHYW1lRXZlbnRcclxufSBmcm9tICcuL0dhbWVFdmVudCc7XHJcblxyXG5jb25zdCBfdGFibGUgPSBTeW1ib2woKTtcclxuY29uc3QgX3VwZGF0ZUNlbGxJbWFnZSA9IFN5bWJvbCgpO1xyXG5jb25zdCBfdGlsZUdyaWQgPSBTeW1ib2woKTtcclxuZXhwb3J0IGNsYXNzIFRpbGVHcmlkVGFibGUge1xyXG5cclxuICBjb25zdHJ1Y3Rvcih0aWxlR3JpZCkge1xyXG4gICAgdGhpc1tfdGlsZUdyaWRdID0gdGlsZUdyaWQ7XHJcbiAgICBHYW1lRXZlbnQuYWRkRXZlbnRMaXN0ZW5lcignZ2FtZUVuZEV2ZW50JywgKCkgPT4ge1xyXG4gICAgICB0aGlzW190YWJsZV0uc3R5bGUuYm9yZGVyQ29sb3IgPSAnIzAwODAwMCc7XHJcbiAgICB9KTtcclxuICB9XHJcblxyXG4gIC8vIHRoZSBncmlkIHdpbGwgYmUgdGFibGUgY2VsbHMgd2l0aCBpbWFnZXNcclxuICBjcmVhdGVUaWxlTWFwKCkge1xyXG4gICAgbGV0IHRhYmxlR3JpZCA9IGRvY3VtZW50LmNyZWF0ZUVsZW1lbnQoJ3RhYmxlJyk7XHJcbiAgICAvLyBDcmVhdGUgdGhlIHRhYmxlIGJvZHkgKHJvd3MsIGNvbHVtbnMpXHJcbiAgICBmb3IgKGxldCBpID0gMDsgaSA8IHRoaXNbX3RpbGVHcmlkXS50aWxlcy5sZW5ndGg7IGkrKykge1xyXG4gICAgICBsZXQgdHIgPSBkb2N1bWVudC5jcmVhdGVFbGVtZW50KCd0cicpO1xyXG4gICAgICBmb3IgKGxldCBqID0gMDsgaiA8IHRoaXNbX3RpbGVHcmlkXS50aWxlc1tpXS5sZW5ndGg7IGorKykge1xyXG4gICAgICAgIGxldCB0ZCA9IGRvY3VtZW50LmNyZWF0ZUVsZW1lbnQoJ3RkJyk7XHJcbiAgICAgICAgbGV0IHRpbGUgPSBkb2N1bWVudC5jcmVhdGVFbGVtZW50KCdpbWcnKTtcclxuICAgICAgICB0aWxlLnNyYyA9IGAvaW1hZ2VzL3Nva29iYW4vJHt0aGlzW190aWxlR3JpZF0udGlsZXNbaV1bal0udGlsZUltYWdlfWA7XHJcbiAgICAgICAgdGQuc3R5bGUud2lkdGggPSB0aGlzW190aWxlR3JpZF0udGlsZURpbWVuc2lvbkluUHJlY2VudCArICclJztcclxuICAgICAgICB0ZC5zdHlsZS5oZWlnaHQgPSB0aGlzW190aWxlR3JpZF0udGlsZURpbWVuc2lvbkluUHJlY2VudCArICclJztcclxuICAgICAgICB0ZC5hcHBlbmRDaGlsZCh0aWxlKTtcclxuICAgICAgICB0ci5hcHBlbmRDaGlsZCh0ZCk7XHJcbiAgICAgIH1cclxuICAgICAgdGFibGVHcmlkLmFwcGVuZENoaWxkKHRyKTtcclxuICAgIH1cclxuICAgIHRhYmxlR3JpZC5zdHlsZS5ib3JkZXIgPSAnMnB4IHNvbGlkICNGRkMxMDcnO1xyXG5cclxuICAgIHRoaXNbX3RhYmxlXSA9IHRhYmxlR3JpZDtcclxuICAgIHJldHVybiB0aGlzW190YWJsZV07XHJcbiAgfVxyXG5cclxuICAvLyBzeW5jIHRoZSB0aWxlIGdyaWQgYW5kIHRhYmxlIGNlbGxcclxuICB1cGRhdGVUaWxlcyh0aWxlcykge1xyXG4gICAgdGlsZXMuZm9yRWFjaCh0aWxlID0+IHtcclxuICAgICAgdGhpc1tfdXBkYXRlQ2VsbEltYWdlXSh0aWxlKTtcclxuICAgIH0pO1xyXG4gIH1cclxuXHJcbiAgLy8gdXBkYXRldCB0aGUgY2VsbFxyXG4gIFtfdXBkYXRlQ2VsbEltYWdlXSh0aWxlKSB7XHJcbiAgICBsZXQgdGlsZUltYWdlID0gdGhpc1tfdGFibGVdLnJvd3NbdGlsZS5yb3ddLmNlbGxzLml0ZW0odGlsZS5jb2x1bW4pLmZpcnN0Q2hpbGQ7XHJcbiAgICB0aWxlSW1hZ2Uuc3JjID0gYC9pbWFnZXMvc29rb2Jhbi8ke3RpbGUudGlsZUltYWdlfWA7XHJcbiAgfVxyXG59IiwiXHJcbmltcG9ydCB7XHJcbiAgU29rb2JhblxyXG59IGZyb20gJy4vU29rb2Jhbic7XHJcbmltcG9ydCB7IEdhbWVFdmVudCB9IGZyb20gJy4vR2FtZUV2ZW50JztcclxuXHJcbi8vICNyZWdpb24gRG9tIGVsZW1lbnRzXHJcbmxldCBncmlkUmVuZGVyID0gZG9jdW1lbnQuZ2V0RWxlbWVudEJ5SWQoJ2dyaWRSZW5kZXJpbmdFbmdpbmVzSWQnKTtcclxubGV0IGdyaWRSZW5kZXJFbmdpbmVzID0gZ3JpZFJlbmRlci5nZXRFbGVtZW50c0J5VGFnTmFtZSgnYnV0dG9uJyk7XHJcbmxldCBnYW1lQ29udGFpbmVyID0gZG9jdW1lbnQuZ2V0RWxlbWVudEJ5SWQoJ2dhbWVDb250YWluZXJJZCcpO1xyXG5sZXQgcmVuZGVyQ29udGFpbmVyID0gZG9jdW1lbnQuZ2V0RWxlbWVudEJ5SWQoJ3JlbmRlckNvbnRhaW5lcklkJyk7XHJcbmxldCByZW5kZXJFbmdpbmUgPSBkb2N1bWVudC5nZXRFbGVtZW50QnlJZCgncmVuZGVyRW5naW5lSWQnKTtcclxubGV0IGxldmVsU2VsZWN0ID0gZG9jdW1lbnQuZ2V0RWxlbWVudEJ5SWQoJ2xldmVsU2VsZWN0SWQnKTtcclxubGV0IG1vdmVzSGlzdG9yeUJ1dHRvbnMgPSBkb2N1bWVudC5nZXRFbGVtZW50QnlJZCgnbW92ZXNIaXN0b3J5QnV0dG9uc0lkJykuZ2V0RWxlbWVudHNCeVRhZ05hbWUoJ2J1dHRvbicpO1xyXG5sZXQgcmVzdGFydEJ1dHRvbiA9IGRvY3VtZW50LmdldEVsZW1lbnRCeUlkKCdyZXN0YXJ0QnV0dG9uSWQnKTtcclxubGV0IG1vdmVtZW50SW5kZXggPSBkb2N1bWVudC5nZXRFbGVtZW50QnlJZCgnbW92ZW1lbnRJbmRleElkJyk7XHJcbmxldCB0aW1lID0gZG9jdW1lbnQuZ2V0RWxlbWVudEJ5SWQoJ3RpbWVJZCcpO1xyXG4vLyAjZW5kcmVnaW9uXHJcblxyXG4vLyB2YXJpYWJsZSB0byBrZWVwIHRyYWNrIHRoZSBoZWlnaHQgYW5kIHdpZHRoIG9mIHRoZSB0aWxlTWFwIGFuZCB0aGUgc2VsZWN0ZWQgcmVuZGVyaW5nXHJcbmxldCBncmlkSGVpZ2h0ID0gKGRvY3VtZW50LmRvY3VtZW50RWxlbWVudC5jbGllbnRIZWlnaHQsIHdpbmRvdy5pbm5lckhlaWdodCB8fCAwKTtcclxubGV0IGdyaWRXaWR0aCA9IHJlbmRlckNvbnRhaW5lci5jbGllbnRXaWR0aDtcclxubGV0IHNlbGVjdGVkUmVuZGVyaW5nRW5naW5lID0gXCJ0YWJsZVwiO1xyXG5cclxuLy8gSW5pdGlhbCBUYWJsZSBHcmlkXHJcbmNvbnN0IHNva29iYW4gPSBuZXcgU29rb2JhbihncmlkV2lkdGgsIGdyaWRIZWlnaHQpO1xyXG5cclxuLy8gZGVmYXVsdCB0byB0YWJsZVJlbmRlcmluZ1xyXG5yZW5kZXIoc2VsZWN0ZWRSZW5kZXJpbmdFbmdpbmUpO1xyXG5cclxuLy8gQWRkIGV2ZW50IHdoZW4gbGV2ZWwgaXMgY2hhbmdlZFxyXG5sZXZlbFNlbGVjdC5hZGRFdmVudExpc3RlbmVyKCdjaGFuZ2UnLCBmdW5jdGlvbiAoKSB7XHJcbiAgc29rb2Jhbi5zZWxlY3RNYXAobGV2ZWxTZWxlY3QudmFsdWUpO1xyXG4gIHJlbmRlcihzZWxlY3RlZFJlbmRlcmluZ0VuZ2luZSk7XHJcbn0pO1xyXG5cclxuLy8gQWRkIGNsaWNrIGV2ZW50IGZvciBlYWNoIHJlbmRlcmluZyBlbmdpbmVcclxuZm9yIChsZXQgaSA9IDA7IGkgPCBncmlkUmVuZGVyRW5naW5lcy5sZW5ndGg7IGkrKykge1xyXG4gIGdyaWRSZW5kZXJFbmdpbmVzW2ldLmFkZEV2ZW50TGlzdGVuZXIoJ2NsaWNrJywgZnVuY3Rpb24gKCkge1xyXG4gICAgY29uc3QgcmVuZGVyaW5nRW5naW5lID0gZ3JpZFJlbmRlckVuZ2luZXNbaV0uZ2V0QXR0cmlidXRlKFwidG9nZ2xlLXJlbmRlcmluZ1wiKTtcclxuICAgIGlmIChyZW5kZXJpbmdFbmdpbmUgIT09IHNlbGVjdGVkUmVuZGVyaW5nRW5naW5lKSB7XHJcbiAgICAgIC8vIFJlbW92ZSBhY3RpdmUgY2xhc3MgZnJvbSB0aGUgb2xkIHJlbmRlciBlbmdpbmVcclxuICAgICAgZ3JpZFJlbmRlci5xdWVyeVNlbGVjdG9yKGBbdG9nZ2xlLXJlbmRlcmluZz1cIiR7c2VsZWN0ZWRSZW5kZXJpbmdFbmdpbmV9XCJdYCkuY2xhc3NMaXN0LnJlbW92ZSgnYWN0aXZlJyk7XHJcbiAgICAgIC8vIEFkZCBhY3RpdmUgY2xhc3MgdG8gdGhlIG5ldyByZW5kZXJpbmcgZW5naW5lXHJcbiAgICAgIGdyaWRSZW5kZXJFbmdpbmVzW2ldLmNsYXNzTGlzdC5hZGQoJ2FjdGl2ZScpO1xyXG4gICAgICAvLyBVcGRhdGUgdGhlIHNlbGVjdGVkIHJlbmRlcmluZyBlbmdpbmVcclxuICAgICAgc2VsZWN0ZWRSZW5kZXJpbmdFbmdpbmUgPSByZW5kZXJpbmdFbmdpbmU7XHJcblxyXG4gICAgICBzb2tvYmFuLnNldFJlbmRlckVuZ2luZShzZWxlY3RlZFJlbmRlcmluZ0VuZ2luZSk7XHJcbiAgICB9XHJcbiAgfSk7XHJcbn1cclxuXHJcbi8vIEFkZCBjbGljayBldmVudCBmb3IgdGhlIG1vdmVzIGJ1dHRvbnNcclxuZm9yIChsZXQgaSA9IDA7IGkgPCBtb3Zlc0hpc3RvcnlCdXR0b25zLmxlbmd0aDsgaSsrKSB7XHJcbiAgbW92ZXNIaXN0b3J5QnV0dG9uc1tpXS5hZGRFdmVudExpc3RlbmVyKCdjbGljaycsIGZ1bmN0aW9uICgpIHtcclxuICAgIGNvbnN0IG1vdmVBbW91bnQgPSBtb3Zlc0hpc3RvcnlCdXR0b25zW2ldLmdldEF0dHJpYnV0ZShcIm1vdmUtYW1vdW50XCIpO1xyXG4gICAgc29rb2Jhbi5wbGF5TW92ZShwYXJzZUludChtb3ZlQW1vdW50KSk7XHJcbiAgICBtb3ZlbWVudEluZGV4LmlubmVyVGV4dCA9IHNva29iYW4uZ2FtZUNvbnRyb2wuaW5kZXhNb3ZlO1xyXG4gIH0pO1xyXG59XHJcbi8vIFVwZGF0ZSB0aGUgcmVuZGVyIGVuZ2luZSBkaW1lbnNpb24gd2hlbiByZXNpemVcclxud2luZG93LmFkZEV2ZW50TGlzdGVuZXIoJ3Jlc2l6ZScsIGZ1bmN0aW9uICgpIHtcclxuICBncmlkSGVpZ2h0ID0gKGRvY3VtZW50LmRvY3VtZW50RWxlbWVudC5jbGllbnRIZWlnaHQsIHdpbmRvdy5pbm5lckhlaWdodCB8fCAwKTtcclxuICBncmlkV2lkdGggPSByZW5kZXJDb250YWluZXIuY2xpZW50V2lkdGg7XHJcbiAgc29rb2Jhbi50aWxlR3JpZC51cGRhdGVUaWxlR3JpZERpbWVuc2lvbihncmlkSGVpZ2h0LCBncmlkV2lkdGgpO1xyXG4gIHNldFJlbmRlckVuZ2luZURpbWVuc2lvbigpO1xyXG59LCB0cnVlKTtcclxuLy8ga2V5IGV2ZW50IG9ubHkgZm9yIHRoZSBnYW1lIGJvYXJkXHJcbmdhbWVDb250YWluZXIuYWRkRXZlbnRMaXN0ZW5lcigna2V5ZG93bicsIGZ1bmN0aW9uIChlKSB7XHJcbiAgY2FwdHVyZUtleShlKTtcclxufSk7XHJcbi8vIFJlc3RhcnQgQnV0dG9uXHJcbnJlc3RhcnRCdXR0b24uYWRkRXZlbnRMaXN0ZW5lcignY2xpY2snLCBmdW5jdGlvbiAoKSB7XHJcbiAgc29rb2Jhbi5yZXN0YXJ0KCk7XHJcbiAgcmVuZGVyKHNlbGVjdGVkUmVuZGVyaW5nRW5naW5lKTtcclxufSk7XHJcbi8vIFVwZGF0ZSBUaW1lXHJcbkdhbWVFdmVudC5hZGRFdmVudExpc3RlbmVyKCd0aW1lQ2hhbmdlRXZlbnQnLCBmdW5jdGlvbiAoKSB7XHJcbiAgdGltZS5pbm5lclRleHQgPSBzb2tvYmFuLmdhbWVDb250cm9sLnRpbWVEdXJhdGlvbjtcclxufSk7XHJcbkdhbWVFdmVudC5hZGRFdmVudExpc3RlbmVyKCdpbmRleE1vdmVDaGFuZ2VFdmVudCcsIGZ1bmN0aW9uICgpIHtcclxuICBtb3ZlbWVudEluZGV4LmlubmVyVGV4dCA9IHNva29iYW4uZ2FtZUNvbnRyb2wuaW5kZXhNb3ZlO1xyXG59KTtcclxuLy8gRm9jdXMgb24gdGhlIGdyaWQgdG8gcmVjaXZlIGtleSBpbnB1dCBhZnRlciBwYWdlIGxvYWRcclxud2luZG93LmFkZEV2ZW50TGlzdGVuZXIoJ2xvYWQnLCBmdW5jdGlvbiAoKSB7XHJcbiAgZ2FtZUNvbnRhaW5lci5mb2N1cygpO1xyXG4gIC8vIHByZWxvYWQgdGhlIGltYWdlXHJcbiAgbmV3IEltYWdlKCkuc3JjID0gXCIvaW1hZ2VzL3Nva29iYW4vY29ycmVjdF9ib3gucG5nXCI7XHJcbn0pO1xyXG4vLyBNYXAgdGhlIGtleWJvYXJkIGtleXMgdG8gZGlyZWN0aW9uXHJcbmZ1bmN0aW9uIGNhcHR1cmVLZXkoa2V5Qm9hcmRFdmVudCkge1xyXG4gIGtleUJvYXJkRXZlbnQucHJldmVudERlZmF1bHQoKTtcclxuICBzd2l0Y2ggKGtleUJvYXJkRXZlbnQua2V5Q29kZSkge1xyXG4gICAgLy8gbGVmdFxyXG4gICAgY2FzZSAzNzpcclxuICAgICAgc29rb2Jhbi5tb3ZlKDAsIC0xKTtcclxuICAgICAgYnJlYWs7XHJcbiAgICAvLyB0b3BcclxuICAgIGNhc2UgMzg6XHJcbiAgICAgIHNva29iYW4ubW92ZSgtMSwgMCk7XHJcbiAgICAgIGJyZWFrO1xyXG4gICAgLy8gcmlnaHRcclxuICAgIGNhc2UgMzk6XHJcbiAgICAgIHNva29iYW4ubW92ZSgwLCAxKTtcclxuICAgICAgYnJlYWs7XHJcbiAgICAvLyBib3R0b21cclxuICAgIGNhc2UgNDA6XHJcbiAgICAgIHNva29iYW4ubW92ZSgxLCAwKTtcclxuICAgICAgYnJlYWs7XHJcbiAgICBkZWZhdWx0OlxyXG4gICAgICBicmVhaztcclxuICB9XHJcbn1cclxuLy8gRHJhdyB0aGUgdGlsZU1hcFxyXG5mdW5jdGlvbiByZW5kZXIocmVuZGVyaW5nRW5naW5lKSB7XHJcbiAgc29rb2Jhbi5zZXRSZW5kZXJFbmdpbmUocmVuZGVyaW5nRW5naW5lKTtcclxuICAvLyBjbGVhciB0aGUgcHJldmlvdXNlIHJlbmRlclxyXG4gIHJlbmRlckVuZ2luZS5pbm5lckhUTUwgPSBcIlwiO1xyXG4gIC8vIGNyZWF0ZSB0aGUgdGFibGUgZ3JpZFxyXG4gIGxldCB0aWxlTWFwID0gc29rb2Jhbi5jcmVhdGVUaWxlTWFwKCk7XHJcbiAgLy8gYWRkIHRoZSBuZXcgcmVuZGVyXHJcbiAgcmVuZGVyRW5naW5lLmFwcGVuZENoaWxkKHRpbGVNYXApO1xyXG4gIC8vIHNldCB0aGUgd2lkdGggYW5kIGhlaWdodCBvZiB0aGUgcmVuZGVyXHJcbiAgc2V0UmVuZGVyRW5naW5lRGltZW5zaW9uKCk7XHJcbn1cclxuLy8gU2V0IHRoZSB3aWR0aCBhbmQgaGVpZ2h0IG9mIHRoZSB0aWxlTWFwXHJcbmZ1bmN0aW9uIHNldFJlbmRlckVuZ2luZURpbWVuc2lvbigpIHtcclxuICByZW5kZXJFbmdpbmUuc3R5bGUud2lkdGggPSBzb2tvYmFuLnRpbGVHcmlkLnRpbGVHcmlkRGltZW5zaW9uICsgJ3B4JztcclxufSIsIm1vZHVsZS5leHBvcnRzID0gX193ZWJwYWNrX3B1YmxpY19wYXRoX18gKyBcImNzcy9zb2tvYmFuLmNzc1wiOyJdLCJzb3VyY2VSb290IjoiIn0=