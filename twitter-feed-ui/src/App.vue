<script setup>
import { computed, ref } from 'vue'
import Twitter from 'vue-material-design-icons/Twitter.vue'
import HeartOutline from 'vue-material-design-icons/HeartOutline.vue'
import ChartBar from 'vue-material-design-icons/ChartBar.vue'
import MessageOutline from 'vue-material-design-icons/MessageOutline.vue'
import Sync from 'vue-material-design-icons/Sync.vue'
import gql from "graphql-tag"
import { useQuery } from "@vue/apollo-composable"

let tweets = ref([])

const QUERY_TWEETS = gql`
query {
      tweets {
          edges {
              node {
                  id,
                  name,
                  handle,
                  tweetBody,
                  comments,
                  retweets,
                  likes,
                  analytics
              },
              cursor
            },
            pageInfo 
            {
              endCursor
              hasNextPage
            }
          }
        }
`

const { result } = useQuery(QUERY_TWEETS)
tweets = computed(() => result.value?.tweets?.edges?.map(x => x.node) ?? [])

</script>

<template>
  <div class="bg-black fixed w-full h-screen no-scrollbar overflow-auto">
      <div class="md:w-1/2 w-[400px] h-[lvh] max-w-[500px] md:mx-auto">
        <div class="p-2 mb-4">
          <Twitter fillColor="#FFFFFF" :size="40" />
        </div>
        <!-- tweet container -->
        <div v-for="tweet in tweets" :key="tweet.id" class="text-white flex">
          <!-- tweet -->
          <div class="min-w-[60px]">
            <img class="rounded-full m-2 mt-3" width="50" alt="userThumbnail" src="/Image_thumbnail.png">
          </div>
          <div class="p-2 w-full">
            <div class="font-extrabold flex items-center justify-between mt-0.5 mb-1.5">
              <div class="flex items-center">
                <div>{{ tweet.name }}</div>
                <span class="font-[300] text-[15px] text-gray-500 pl-2">{{ tweet.handle }}</span>
              </div>
            </div>
            <div class="pb-3">{{ tweet.tweetBody }}</div>
            <div class="pb-3">
              <img alt="imageFile" src="/Image.png" class="mt-2 object-fill rounded-xl w-full" />
            </div>
            <div class="flex items-center justify-between mt-4 w-4/5">
              <div class="flex">
                <MessageOutline fillColor="#5e5c5c" :size="23" />
                <span class="text-s font-extrabold text-[#5e5c5c] ml-3">{{ tweet.comments }}</span>
              </div>
              <div class="flex">
                <Sync fillColor="#5e5c5c" :size="23" />
                <span class="text-s font-extrabold text-[#5e5c5c] ml-3">{{ tweet.retweets }}</span>
              </div>
              <div class="flex">
                  <HeartOutline fillColor="#5e5c5c" :size="23" />
                <span class="text-s font-extrabold text-[#5e5c5c] ml-3">{{ tweet.likes }}</span>
              </div>
              <div class="flex">
                <ChartBar fillColor="#5e5c5c" :size="23" />
                <span class="text-s font-extrabold text-[#5e5c5c] ml-3">{{ tweet.analytics }}</span>
              </div>
            </div>
          </div>
        </div>
        <div class="mt-4" />
      </div>
  </div>
</template>

<style scoped>
.no-scrollbar::-webkit-scrollbar {
    display: none;
}

.no-scrollbar {
    -ms-overflow-style: none; 
    scrollbar-width: none;
}
</style>