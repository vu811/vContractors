import Head from 'next/head'
import '../styles/globals.css'
import DefaultLayout from '../layouts/defaultLayout'
import 'semantic-ui-css/semantic.min.css'

function MyApp({ Component, pageProps }) {
  return (
    <>
      <Head>
        <title>VContractor</title>
        <meta name='viewport' content='width=device-width, initial-scale=1.0' />
        <link rel='icon' href='/favicon.png' />
      </Head>
      <DefaultLayout>
        <Component {...pageProps} />
      </DefaultLayout>
    </>
  )
}

export default MyApp
