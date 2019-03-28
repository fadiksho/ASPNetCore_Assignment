const path = require("path");
const webpack = require("webpack");

module.exports = {

  entry: {
    main: ["./src/index.js", "./src/site.scss"],
		sokoban: ["./src/js/sokoban.js", "./src/sass/projects/sokoban.scss"],
    person: ["./src/js/person.js"],
    schoolManagement: ["./src/js/schoolManagement.js", "./src/sass/school_management.scss"]
  },
  mode: "development",
  devtool: 'inline-source-map',

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
          loader: 'file-loader',
          options: {
            name: 'css/[name].css'
          }
        },
        {
          loader: 'extract-loader'
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
      test: /\.(jpg|jpeg|png|ico)$/,
      use: [{
        loader: "file-loader",
        options: {
          name: "[path]/[name].[ext]",
          outputPath: (file) => {
            let path = file.split("src/")[1];
            return path;
          }
        }
      }]
    }
    ]
  },
	plugins: [
		new webpack.ProvidePlugin({
			$: 'jquery',
			jQuery: 'jquery'
		})
  ]
};