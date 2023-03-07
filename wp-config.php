<?php
define( 'WP_CACHE', true );
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the
 * installation. You don't have to use the web site, you can
 * copy this file to "wp-config.php" and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * MySQL settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://wordpress.org/support/article/editing-wp-config-php/
 *
 * @package WordPress
 */

// ** MySQL settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define( 'DB_NAME', 'thew_website' );

/** MySQL database username */
define( 'DB_USER', 'thew_website' );

/** MySQL database password */
define( 'DB_PASSWORD', 'FgHgd3k6tfHBE3!4' );

/** MySQL hostname */
define( 'DB_HOST', 'localhost:3306' );

/** Database Charset to use in creating database tables. */
define( 'DB_CHARSET', 'utf8' );

/** The Database Collate type. Don't change this if in doubt. */
define( 'DB_COLLATE', '' );

/**
 * Authentication Unique Keys and Salts.
 *
 * Change these to different unique phrases!
 * You can generate these using the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}
 * You can change these at any point in time to invalidate all existing cookies. This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define( 'AUTH_KEY',          '_v$c;B,<Y:U-:~Cq.L`dHhH0w I>V)ek1D!O_M_wNe:MM#-[(yl(_X^ko!l}P~vh' );
define( 'SECURE_AUTH_KEY',   'rk84>H4BN*nxIu%: uN!&DjOBU1Tvh`3atG*j-b;>]L+B1 [`pX-m+:H~(BjPTnJ' );
define( 'LOGGED_IN_KEY',     'wu$iKhVM!G&@62[r6xx{d;L$b}`f({d;}u-,?& P;_*eaQu_X*KXur(^d+8_.`z@' );
define( 'NONCE_KEY',         'U~z#jU4{]!cxnG-*t$L%a%xk.::Dsy$WTk.#J@2(7p~]c9mt=c`A;:xvz].B9l_Y' );
define( 'AUTH_SALT',         'T9QXQqd!LzKQTz(J]WJ]M*x?F .yj:IkHd;P pgq?;Z$iUy%Sei{%X`gwX=o1z^8' );
define( 'SECURE_AUTH_SALT',  '_[l<E7z38T=Zz=BK`RC%Bf[Hfgw;Y:8W.iH_7QwIJ]yJ@HnXkD*52)1O4oG=|]/c' );
define( 'LOGGED_IN_SALT',    '_PB^J{P{LcY*u2bP7<,xPD@Uj05vld[i@rWz>t4UmxV5uh)*YsuFXa+ai}k{AwnX' );
define( 'NONCE_SALT',        ';F17d.P#sLte.6eu`(rka]kfCpe`%AYe_5pfjs7[Rp?~[Y|Sqc{$.VI Z.!a)nfX' );
define( 'WP_CACHE_KEY_SALT', 'ARe^S7eJ7Ylz{Ih8<aV4SBLWgOw;XOVPZ>xc3J~l^kTs)nb@b/GG^*V-A,?yhaR=' );

/**
 * WordPress Database Table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix = 'wp_';




/* That's all, stop editing! Happy publishing. */

/** Absolute path to the WordPress directory. */
if ( ! defined( 'ABSPATH' ) ) {
	define( 'ABSPATH', dirname( __FILE__ ) . '/' );
}

/** Sets up WordPress vars and included files. */
require_once ABSPATH . 'wp-settings.php';
