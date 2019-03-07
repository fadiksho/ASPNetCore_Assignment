const path = require("path");
const MiniCssExtractPlugin = require("mini-css-extract-plugin");

module.exports = {
  entry: {
    main: ["./src/index.js", "./src/index.scss"]
  },
  mode: "development",
  devtool: 'inline-source-map',
  watch: true,
  watchOptions: {
    ignored: /node_modules/,
    aggregateTimeout: 0
  },
  output: {
    filename: "js/[name]-bandle.js",
    path: path.resolve(__dirname, "../wwwroot"),
    publicPath: "/"
  },
  module: {
    rules: [{
      test: /\.js$/,
      exclude: /node_modules/,
      use: [{
        loader: "babel-loader",
        options: {
          presets: ['@babel/preset-env'],
          plugins: ['@babel/plugin-transform-runtime']
        }
      }]
    },
    {
      test: /\.(scss|css)$/,
      use: [
        {
          loader: MiniCssExtractPlugin.loader,
          options: {}
        },
        {
          loader: "css-loader"
        },
        {
          loader: "sass-loader"
        }
      ]
    },
    {
      test: /\.(jpg|jpeg|png)$/,
      use: [{
        loader: "file-loader",
        options: {
          name: "images/[name].[ext]"
        }
      }]
    },
    {
      test: /\.(ico)$/,
      use: [{
        loader: "file-loader",
        options: {
          name: "[name].[ext]"
        }
      }]
    }
    ]
  },
  plugins: [
    new MiniCssExtractPlugin({
      filename: 'css/[name].css'
    })
  ]
};